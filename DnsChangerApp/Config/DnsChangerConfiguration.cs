using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;

namespace DnsChanger.Config
{
    /// <remarks>This is the root node for all configuration settings for the dll.</remarks>
    public class DnsChangerConfiguration : ConfigurationSection
    {
        #region configuration file methods

        /// <summary>The name of the section in the config file.</summary>
        private const string s_sectionName = "dnsChangerConfiguration";

        /// <summary>Singleton instance of the DnsChangerConfiguration object.</summary>
        public static DnsChangerConfiguration Instance { get; private set; }

        /// <summary>Load the configuration from the configuration file.</summary>
        /// <returns>The loaded DnsChangerConfiguration.</returns>
        static DnsChangerConfiguration()
        {
            string dllLocation = System.Reflection.Assembly.GetAssembly(typeof(DnsChangerConfiguration)).Location;
            string configLocation = Path.GetDirectoryName(dllLocation) + @"\Config\DnsChanger.config";
            ConfigurationFileMap dllConfig = new ConfigurationFileMap(configLocation);
            Configuration config = ConfigurationManager.OpenMappedMachineConfiguration(dllConfig);

            ConfigurationSection section = config.Sections[s_sectionName] ?? new DnsChangerConfiguration();
            Instance = section as DnsChangerConfiguration;
        }

        /// <summary>Save the current configuration into the configuration file.</summary>
        /// <returns>The ImapFSConfiguration we wish to save.</returns>
        public void Save()
        {
            string dllLocation = System.Reflection.Assembly.GetAssembly(typeof(DnsChangerConfiguration)).Location;
            string configLocation = Path.GetDirectoryName(dllLocation) + @"\Config\DnsChanger.config";
            ConfigurationFileMap dllConfig = new ConfigurationFileMap(configLocation);
            Configuration config = ConfigurationManager.OpenMappedMachineConfiguration(dllConfig);

            ConfigurationSection section = config.Sections[s_sectionName] ?? new DnsChangerConfiguration();
            DnsChangerConfiguration dnsChangerConfiguration = section as DnsChangerConfiguration;

            dnsChangerConfiguration.DnsServers.Clear();
            dnsChangerConfiguration.DnsServers.AddRange(DnsServers);

            config.Save(ConfigurationSaveMode.Full);
        }

        #endregion configuration file methods

        /// <summary>Get and set a collection of all the DnsServers available.</summary>
        [ConfigurationProperty("dnsServers")]
        public DnsServerCollection DnsServers
        {
            get { return this["dnsServers"] as DnsServerCollection; }
        }
    }
}
