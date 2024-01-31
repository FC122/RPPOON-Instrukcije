// namespace KompozitExtra{

// interface IOrganizationComponent
// {
//     void Display();
// }

// class Employee : IOrganizationComponent
// {
//     private string name;
//     private string position;

//     public Employee(string name, string position)
//     {
//         this.name = name;
//         this.position = position;
//     }

//     public void Display()
//     {
//         Console.WriteLine($"Employee: {name}, Position: {position}");
//     }
// }

// class Department : IOrganizationComponent
// {
//     private string name;
//     private List<IOrganizationComponent> members = new List<IOrganizationComponent>();

//     public Department(string name)
//     {
//         this.name = name;
//     }

//     public void Add(IOrganizationComponent component)
//     {
//         members.Add(component);
//     }

//     public void Remove(IOrganizationComponent component)
//     {
//         members.Remove(component);
//     }

//     public void Display()
//     {
//         Console.WriteLine($"Department: {name}");
//         foreach (var member in members)
//         {
//             member.Display();
//         }
//     }
// }

// }