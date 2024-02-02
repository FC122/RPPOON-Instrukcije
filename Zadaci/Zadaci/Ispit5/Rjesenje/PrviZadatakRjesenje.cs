namespace PrviZadatakRjesenjeIspit5
{
    // Preimenuj
    public class LocationInformationData
    {
        public DateTime CreatedAt { get; private set; } // Created at
        public double Latitude { get; private set; } // Latitude coordinate
        public double Longitude { get; private set; } // Longitude coordinate

        public LocationInformationData(double latitude, double longitude)
        {
            // Constructor implementation
        }
    }

    public class PathManager
    {
        private List<LocationInformationData> LocationsList; // The path location points

        public PathManager()
        {
            LocationsList = new List<LocationInformationData>();
        }

        public void AddNewLocationForPath(LocationInformationData location)
        {
            LocationsList.Add(location);
        }

        public void RemoveLocationFromPath(LocationInformationData location)
        {
            LocationsList.Remove(location);
        }
    }
}
