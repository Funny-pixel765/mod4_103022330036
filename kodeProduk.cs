using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace mod4_103022330036
{
    public class kodeProduk
    {
        private static Dictionary<string, string> Produk = new Dictionary<string, string>
            {
                {"Laptop", "E100"},
                {"Smartphone", "E101"},
                {"Tablet", "E102"},
                {"Headset", "E103"},
                {"Keyboard", "E104"},
                {"Mouse", "E105"},
                {"Printer", "E106"},
                {"Monitor", "E107"},
                {"Smartwatch", "E108"},
                {"Kamera", "E109"},
            };

            public string getKodeProduk ( string produk)
            {
            if (Produk.ContainsKey(produk))
            {
                return Produk[produk];
            }
                 return null;
            }
          }
     }
   
