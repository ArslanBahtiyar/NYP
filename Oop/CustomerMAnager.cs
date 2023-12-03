using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    internal class CustomerMAnager
    {
        public void Gonder(List<ICustomerDal> customers)
        {
            foreach (var customer in customers)
            {
                customer.Add();
            }
        }

    }
}
