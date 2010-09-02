using System;
using System.Collections.Generic;
using System.Management;
using System.Net;
using DnsChanger.Exceptions;
using System.Collections.ObjectModel;
using System.Linq;

namespace DnsChanger
{
    /// <remarks>A helper class to get and set Dns server.</remarks>
    public static class DnsHelper
    {
        /// <summary>Set the Dns servers using the.</summary>
        /// <param name="servers">The list of servers we will use.</param>
        /// <returns>true if a reboot isn't needed.</returns>
        /// <exception cref="InvalidServerException">thrown if a server isn't valid.</exception>
        /// <exception cref="DNSServerSearchOrderException">thrown if we get an unexpected return value from the WMI.</exception>
        public static bool SetDnsServers(ReadOnlyCollection<string> servers)
        {
            bool rebootRequired = false;
            List<string> dnsServerList = GetIPAddressList(servers);

            foreach (ManagementObject adapter in GetEnabledAdapters())
            {
                ManagementBaseObject dnsServerSearchOrderParameters = adapter.GetMethodParameters("SetDNSServerSearchOrder");
                if (dnsServerSearchOrderParameters == null) continue;

                dnsServerSearchOrderParameters["DNSServerSearchOrder"] = dnsServerList.ToArray();
                ManagementBaseObject invokeResult = adapter.InvokeMethod("SetDNSServerSearchOrder", dnsServerSearchOrderParameters, null);

                uint returnValue = (uint)invokeResult["ReturnValue"];

                rebootRequired = rebootRequired || (returnValue == 1);

                if (returnValue == 0) continue;

                // not all codes indicate an error so I'll only report it if the settings haven't chnaged.
                if (dnsServerList.Intersect(GetDnsServers()).Count() != dnsServerList.Count)
                {
                    throw new DnsServerSearchOrderException(returnValue);
                }
            }

            return !rebootRequired;
        }

        /// <summary>Get the current Dns servers.</summary>
        /// <returns>a list of servers from the NIC.</returns>
        public static List<string> GetDnsServers()
        {
            List<string> dnsServers = new List<string>();
            foreach (ManagementObject adapter in GetEnabledAdapters())
            {
                ManagementBaseObject dnsServerSearchOrderParameters = adapter.GetMethodParameters("SetDNSServerSearchOrder");
                if (dnsServerSearchOrderParameters == null) continue;

                var servers = (string[])adapter.Properties["DnsServerSearchOrder"].Value;
                
                if (servers == null) continue;
                dnsServers.AddRange(servers);
            }
            return dnsServers;
        }

        #region private Helpers

        /// <summary>Get the enabled Network adapters.</summary>
        /// <returns>the collection of network adapters.</returns>
        private static ManagementObjectCollection GetEnabledAdapters()
        {
            //get the enabled network adapters
            ManagementObjectSearcher adapters = new ManagementObjectSearcher
            {
                Query = new ObjectQuery(@"SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = TRUE")
            };

            return adapters.Get();
        }

        /// <summary>Get IP addresses for and validate a list of servers.</summary>
        /// <param name="servers">A list of servers to query.</param>
        /// <returns>a list of IP addresses.</returns>
        /// <exception cref="InvalidServerException">thrown if a server isn't valid.</exception>
        private static List<string> GetIPAddressList(ReadOnlyCollection<string> servers)
        {
            List<string> dnsServerList = new List<string>();

            foreach (string server in servers)
            {
                if (string.IsNullOrEmpty(server)) continue;

                try
                {
                    IPAddress[] ipList = Dns.GetHostAddresses(server);
                    Array.ForEach(ipList, ip => dnsServerList.Add(ip.ToString()));
                }
                catch (Exception ex)
                {
                    throw new InvalidServerException(server, ex);
                }
            }
            return dnsServerList;
        }

        #endregion private Helpers
    }
}
