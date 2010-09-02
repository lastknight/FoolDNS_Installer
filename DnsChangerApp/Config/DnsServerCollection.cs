using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Collections;

namespace DnsChanger.Config
{
    public class DnsServerCollection : ConfigurationElementCollection, IEnumerable<DnsServerElement>
    {
        #region protected overrides for internal use by the Configuration Manager

        /// <summary>Create a new instance of DnsServerElement, override from ConfigurationElementCollection.</summary>
        /// <returns>Newly created DnsServerElement</returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new DnsServerElement();
        }

        /// <summary>Get the unique identifier for a DnsServerElement, override from ConfigurationElementCollection.</summary>
        /// <param name="element">The element being queried.</param>
        /// <returns>The name of the DnsServerElement</returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((DnsServerElement)element).Name;
        }

        #endregion protected overrides for internal use by the Configuration Manager

        /// <summary>Collection indexer. Get or Set a specific DnsServerElement by index.</summary>
        /// <param name="index">The index into the collection.</param>
        /// <returns>The DnsServerElement specified.</returns>
        public DnsServerElement this[int index]
        {
            get { return BaseGet(index) as DnsServerElement; }
            set
            {
                if (BaseGet(index) != null)
                    BaseRemoveAt(index);

                BaseAdd(index, value);
            }
        }

        /// <summary>
        /// Collection indexer. Get or Set a specific DnsServerElement by Name.
        /// </summary>
        /// <param name="name">The name of the DnsServerElement.</param>
        /// <returns>The DnsServerElement specified.</returns>
        public new DnsServerElement this[string name]
        {
            get
            {
                return BaseGet(name) as DnsServerElement;
            }
            set
            {
                if (BaseGet(name) != null)
                    BaseRemove(name);

                BaseAdd(value);
            }
        }

        #region adds

        /// <summary>Add a new DnsServerElement to the collection.</summary>
        /// <param name="element">The element to be added.</param>
        public void Add(ConfigurationElement element)
        {
            BaseAdd(element);
        }

        /// <summary>Add a list of DnsServerElement to the collection.</summary>
        /// <param name="element">The iterator for the elements to be added.</param>
        public void AddRange(IEnumerable elements)
        {
            foreach (ConfigurationElement element in elements)
            {
                BaseAdd(element);
            }
        }

        #endregion adds

        /// <summary>Clear the collection.</summary>
        public void Clear()
        {
            BaseClear();
        }

        #region IEnumerable<DnsServerElement> Members

        /// <summary>Implement the generic version of IEnumerator to allow for more flexibility.</summary>
        /// <returns>An Enumerator which is used to iterate through the collection.</returns>
        public new IEnumerator<DnsServerElement> GetEnumerator()
        {
            IEnumerator enumerator = base.GetEnumerator();
            while (enumerator.MoveNext())
            {
                yield return enumerator.Current as DnsServerElement;
            }
        }

        #endregion

        /// <summary>Find a server based on it's args.</summary>
        /// <param name="arg">The arg we are trying to find.</param>
        /// <returns></returns>
        public DnsServerElement Find(string arg)
        {
            return this.ToList().Find(s => s.Args.Contains(arg));
        }
    }
}
