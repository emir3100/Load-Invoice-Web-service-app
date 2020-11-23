using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;

namespace InvoiceManagementApp
{
    public class Manager : IEnumerable<InvoiceKeyValuePair>
    {
        private HashSet<InvoiceKeyValuePair> hashSet = new HashSet<InvoiceKeyValuePair>();

        public void LoadFromFile(string FilePath)
        {
            if (FilePath != null && File.Exists(FilePath))
            {
                String line;
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        var array = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var item in array)
                        {
                            string invoiceNumber = Path.GetFileNameWithoutExtension(item);
                            Add(invoiceNumber, item);
                        }
                    }
                }
            }
        }

        public void Add(string key, string line)
        {
            hashSet.Add(new InvoiceKeyValuePair(key, line));
        }

        public string FindURL (string key)
        {
            if (hashSet.TryGetValue(new InvoiceKeyValuePair(key, ""), out InvoiceKeyValuePair value))
                return value.Value;
            else
                return null;
        }

        public IEnumerator<InvoiceKeyValuePair> GetEnumerator()
        {
            return hashSet.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return hashSet.GetEnumerator();
        }
    }
}
