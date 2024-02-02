/*Za primjer da izlistanjem koda odredite obrazac o kojem je rjec i njegovu skupinu.
    Dopunite kod implementacijom koja nedostaje te napisite klijentski kod za ovaj primjer*/

namespace OsmiZadatakIspit5
{
    // public interface INavigator
    // {
    //     void Register(ILocationTracker tracker);
    //     void Unregister(ILocationTracker tracker);
    //     void Notify();
    // }

    // public interface ILocationTracker
    // {
    //     void Update(Location location);
    // }

    // public class LoggingTracker : ILocationTracker
    // {
    //     private string log = "";

    //     public void Update(Location location)
    //     {
    //         log += $"{location}{Environment.NewLine}";
    //     }
    // }

    // public class GpsNavigator : INavigator
    // {
    //     private GPS gps = new GPS();
    //     private Location currentLocation;
    //     private List<Location> previousLocations = new List<Location>();
    //     private List<ILocationTracker> trackers = new List<ILocationTracker>();

    //     public void Move()
    //     {
    //         // Detect location using gps sensor and store previousLocations
    //         previousLocations.Add(currentLocation);
    //         currentLocation = gps.DetermineLocation();
    //         this.Notify();
    //     }

    //     public void Register(ILocationTracker tracker) => trackers.Add(tracker);
    //     public void Unregister(ILocationTracker tracker) => trackers.Remove(tracker);
    //     public void Notify()
    //     {
    //         foreach (var tracker in trackers)
    //         {
    //             tracker.Update(currentLocation);
    //         }
    //     }
    // }
}