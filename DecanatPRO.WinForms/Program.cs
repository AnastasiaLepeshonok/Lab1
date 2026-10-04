using BusinessLogic;
using DataAccessLayer;
using Model;

namespace DecanatPRO.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            DatabaseInitializer.EnsureCreated();
            var logic = new Logic(new EntityRepository<Student>());

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(logic));
        } 
    }
}
