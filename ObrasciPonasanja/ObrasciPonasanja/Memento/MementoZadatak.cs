// namespace MementoZadatak
// {

//     public class CarConfigurator//memento
//     {
//         public string Model { get; private set; }
//         private List<Equipment> additionalEquipment = new List<Equipment>();
//         public void AddExtra(Equipment package) { additionalEquipment.Add(package); }
//         public void Remove(Equipment package) { additionalEquipment.Remove(package); }
//         public void Rollback(CarConfiguration configuration)
//         {
//             Model = configuration.GetModel();
//             additionalEquipment.Clear();
//             additionalEquipment.AddRange(configuration.GetPackages());
//         }
//         public CarConfiguration Store() { return new CarConfiguration(Model, additionalEquipment); }
//     }

//     public class CarConfiguration//origniator
//     {
//         private string model;
//         private List<Equipment> additionalEquipment;

//     }

//     public class ConfigurationManger//skrbnik
//     {
//         private List<CarConfiguration> configurations = new List<CarConfiguration>();
//         public void AddConfiguration(CarConfiguration configuration) { configurations.Add(configuration); }
//         public void DeleteConfiguration(CarConfiguration configuration) { configurations.Remove(configuration); }
//         public CarConfiguration GetConfiguration(int index) { return configurations[index]; }
// }