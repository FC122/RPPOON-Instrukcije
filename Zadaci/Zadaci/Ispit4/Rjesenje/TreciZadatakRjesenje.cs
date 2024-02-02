/*Objasnite što je načelo ISP"? Dajte primjer pseudokoda koji ga narušava i objasnite
u čemu se to ogleda i zašto je to problem. Prepravite kod tako da poštuje navedeno načelo.*/
namespace TreciZadatakRjesenjeIspit4
{
    // // Kršenje ISP
    // interface IWorker
    // {
    //     void Work();
    //     void Eat();
    //     void Sleep();
    // }

    // class Robot : IWorker
    // {
    //     public void Work() { /* implementation */ }
    //     public void Eat() { /* implementation - unnecessary for a robot */ }
    //     public void Sleep() { /* implementation - unnecessary for a robot */ }
    // }
    /*
    Ovaj primjer krši ISP jer klasa Robot mora 
    implementirati metode Eat() i Sleep(), koje su suvišne za robota, ali su definirane u širem sučelju IWorker.

    To je problem jer prisiljava klase koje ne 
    trebaju sve metode sučelja da ih implementiraju, 
    što dovodi do nepotrebnog kodiranja i mogućih grešaka 
    u implementaciji.
    */

    // Ispravak prema ISP
    interface IWorker
    {
        void Work();
    }

    interface IEater
    {
        void Eat();
    }

    interface ISleeper
    {
        void Sleep();
    }

    class Robot : IWorker
    {
        public void Work() { /* implementation */ }
    }

}