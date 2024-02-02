namespace PrviZadatakIspit5
{
    //Preimenuj
    public class LocationInformationData
    {
        public DateTime DATC { get; private set; } // created at
        public double LatofLoc { get; private set; } // latitude coordinate
        public double Longofloc { get; private set; } // longitude coordinate

        public LocationInformationData(double Lat, double Long)
        {
            // Constructor implementation
        }
    }

    public class PathManaging
    {
        private List<LocationInformationData> LocationsList; // the path location points

        public PathManaging()
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