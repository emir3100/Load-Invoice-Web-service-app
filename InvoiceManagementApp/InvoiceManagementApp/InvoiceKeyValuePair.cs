using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagementApp
{
    public class InvoiceKeyValuePair
    {
        public readonly string Key;
        public readonly string Value;
        public InvoiceKeyValuePair(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is InvoiceKeyValuePair ikvp ? Key == ikvp.Key : false;
        }
    }
}
