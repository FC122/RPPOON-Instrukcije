/*
Za primjer dan izlistanjem kôda odredite obrazac o 
kojem je riječ i njegovu skupinu. Dopunite kôd 
implementacijom koja nedostaje te napišite 
klijentski kôd za ovaj primjer.
*/
/*Kompozit*/
namespace PetiRjesenje
{
    interface IOrganizationComponent
    {
        void Display();
    }

    class Employee : IOrganizationComponent
    {
        private string name;
        private string position;

        public Employee(string name, string position)
        {
            this.name = name;
            this.position = position;
        }

        public void Display()
        {
            Console.WriteLine($"Employee: {name}, Position: {position}");
        }
    }

    class Department : IOrganizationComponent
    {
        private string name;
        private List<IOrganizationComponent> members = new List<IOrganizationComponent>();

        public Department(string name)
        {
            this.name = name;
        }

        public void Add(IOrganizationComponent component)
        {
            members.Add(component);
        }

        public void Remove(IOrganizationComponent component)
        {
            members.Remove(component);
        }

        public void Display()
        {
            Console.WriteLine($"Department: {name}");
            foreach (var member in members)
            {
                member.Display();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Klijentski kod
            Department engineeringDepartment = new Department("Engineering");
            engineeringDepartment.Add(new Employee("John Doe", "Software Engineer"));
            engineeringDepartment.Add(new Employee("Jane Smith", "QA Engineer"));

            Department salesDepartment = new Department("Sales");
            salesDepartment.Add(new Employee("Michael Johnson", "Sales Manager"));
            salesDepartment.Add(new Employee("Emily Davis", "Sales Representative"));

            Department company = new Department("Company");
            company.Add(engineeringDepartment);
            company.Add(salesDepartment);

            company.Display();
        }
    }
}
