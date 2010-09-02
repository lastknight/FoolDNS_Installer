using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Collections.ObjectModel;

namespace DnsChanger.Config
{
    /// <remarks>Holds the configuration values for a single dns server.</remarks>
    public class DnsServerElement : ConfigurationElement
    {
        /// <summary>The Name to be displayed identifying the server.</summary>
        [ConfigurationProperty("name")]
        public string Name
        {
            get { return this["name"] as string; }
            set { this["name"] = value; }
        }

        #region Args

        /// <summary>The args allowed to be used on the command line.</summary>
        [ConfigurationProperty("args")]
        public string ConfigArgs
        {
            get { return this["args"] as string; }
            set { this["args"] = value; }
        }

        /// <summary>The args allowed to be used on the command line.</summary>
        public ReadOnlyCollection<string> Args
        {
            get
            {
                IEnumerable<string> args = from a in ConfigArgs.Trim().Split(',') select a.Trim();
                args = from a in args where !string.IsNullOrEmpty(a) select a;
                return args.ToList().AsReadOnly();
            }
        }

        #endregion Args

        /// <summary>An info setting for more information on the server.</summary>
        [ConfigurationProperty("info")]
        public string Info
        {
            get { return this["info"] as string; }
            set { this["info"] = value; }
        }

        #region Servers

        /// <summary>The servers user by this Dns server.</summary>
        [ConfigurationProperty("servers")]
        public string ConfigServers
        {
            get { return this["servers"] as string; }
            set { this["servers"] = value; }
        }

        /// <summary>The servers user by this Dns server.</summary>
        public ReadOnlyCollection<string> Servers
        {
            get
            {
                IEnumerable<string> servers = from s in ConfigServers.Trim().Split(',') select s.Trim();
                servers = from s in servers where !string.IsNullOrEmpty(s) select s;
                return servers.ToList().AsReadOnly();
            }
        }

        #endregion Servers
    }
}
