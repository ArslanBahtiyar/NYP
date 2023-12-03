using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    internal class SqlServerCustomerDal : ICustomerDal  
    {
        public void Add()
        {
           Console.WriteLine("sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("sql Deleted");
        }

        public void Update()
        {
           Console.WriteLine("sql Updated");
        }
    }
}
