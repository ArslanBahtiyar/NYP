using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSon
{
    internal class CustomerMaanager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Add");
        }

    }
}
