namespace TreciZadatakRjesenje
{
    /*Dajte primjer pseudokoda koji narusava nacelo open/closed 
    principle te objasnite u cemu se to ogleda i zasto je to problem*/

    class Event
    {
        public void Execute()
        {

        }
    }

    class HistoricalEvent
    {
        public void ExecuteHistoricalEvent()
        {

        }
    }

    class EventHandler
    {
        void HandleEvents(List<Event> events, HistoricalEvent historicalEvent)
        {
            events.ForEach(e =>
            {
                e.Execute();
            });
            historicalEvent.ExecuteHistoricalEvent();
        }
    }

    /*Klase trebaju biti zatvorene za izmjene, ali otvorene za prosirenja*/
    /*U ovom primjeru to se ogleda u tome sto je klasa Event u crvstoj sprezi 
    sa klasom Event Handler*/
    /*To je problem u slucaju kad zelimo dodati novu vrstu Eventa jer trebamo 
    mijenjati klasu EventHandler kako bi je prilagodili novom eventu*/

}