using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pharmacy ph = new Pharmacy(100);
            ph.AddProductLocal();
        }
    }
}
