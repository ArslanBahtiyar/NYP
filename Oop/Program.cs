namespace Oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //customer.Id = 1;
            //customer.FirstName = "Bahtiyar";
            //customer.LastName = "Arslan";
            //customer.City = "Van";

            //Console.WriteLine(customer.FirstName);

            ICustomerDal sqlServerCusmoterDal = new SqlServerCustomerDal();
            ICustomerDal oracleCusmoterDal = new OracleCustomerDal();

            List<ICustomerDal> dals=new List<ICustomerDal>() {sqlServerCusmoterDal,oracleCusmoterDal};

            CustomerMAnager customerMAnager = new CustomerMAnager();

            customerMAnager.Gonder(dals);


        }
    }
}