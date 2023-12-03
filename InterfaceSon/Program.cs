namespace InterfaceSon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customerManager=new CustomerMaanager();  // instance olusturma
            //IPersonManager emploooyeManager=new EmplooyeMaanager();

            ProjectManager projectManager = new ProjectManager();
            List<IPersonManager> personManagerList = new List<IPersonManager>() { new EmplooyeMaanager(), new CustomerMaanager() };
            IPersonManager[] personManagers = new IPersonManager[2] { new CustomerMaanager(), new EmplooyeMaanager() };

            projectManager.Add(new EmplooyeMaanager());

        }
    }
}