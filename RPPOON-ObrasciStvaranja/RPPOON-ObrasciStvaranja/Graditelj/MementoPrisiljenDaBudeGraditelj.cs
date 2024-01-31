namespace MementoPrisiljenDaBudeIGraditelj
{

    public class Equipment
    {
        string name;

        public Equipment(string name)
        {
            this.name = name;
        }
    }
    interface ICarConfigurator
    {
        public void Rollback(CarConfiguration configuration);
        public void AddExtra(Equipment package);
        public void Remove(Equipment package);
        public CarConfiguration Store();
    }

    public class CarConfigurator : ICarConfigurator
    {
        public string Model { get; private set; }
        private List<Equipment> additionalEquipment = new List<Equipment>();


        public CarConfigurator(string Model, List<Equipment> equipment)
        {
            this.Model = Model;
            this.additionalEquipment = equipment;
        }

        public void Rollback(CarConfiguration configuration)
        {
            Model = configuration.GetModel();
            additionalEquipment.Clear();
            additionalEquipment.AddRange(configuration.GetPackages());
        }

        public CarConfiguration Store() { return new CarConfiguration(Model, additionalEquipment); }

        public void AddExtra(Equipment package)
        {
            additionalEquipment.Add(package);
        }

        public void Remove(Equipment package)
        {
            additionalEquipment.Remove(package);
        }

    }

    public class CarConfiguration//izvornik
    {
        private string model;
        private List<Equipment> additionalEquipment;


        public void AddExtra(Equipment package) { additionalEquipment.Add(package); }
        public void Remove(Equipment package) { additionalEquipment.Remove(package); }
        public CarConfiguration(string model, List<Equipment> additionalEquipment)
        {
            this.model = model;
            this.additionalEquipment = additionalEquipment;
        }
        public string GetModel()
        {
            return model;
        }
        public List<Equipment> GetPackages()
        {
            return additionalEquipment;
        }
    }

    public class ConfigurationManger//skrbnik
    {
        private List<CarConfiguration> configurations = new List<CarConfiguration>();
        public void AddConfiguration(CarConfiguration configuration) { configurations.Add(configuration); }
        public void DeleteConfiguration(CarConfiguration configuration) { configurations.Remove(configuration); }
        public CarConfiguration GetConfiguration(int index) { return configurations[index]; }

        public CarConfiguration GefufnaCincilator()
        {
            return new CarConfiguration("Folcika", new List<Equipment>() { new Equipment("Cincilator"), new Equipment("Gefufna") });
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            CarConfiguration carConfiguration = new CarConfiguration("Folcika", new List<Equipment>());
            carConfiguration.AddExtra(new Equipment("Cincilator"));
            carConfiguration.AddExtra(new Equipment("Gefufna"));

            CarConfigurator carConfigurator = new CarConfigurator(carConfiguration.GetModel(), carConfiguration.GetPackages());



            carConfiguration = carConfigurator.Store();

            carConfiguration.AddExtra(new Equipment("Gefufna"));
        }
    }
}