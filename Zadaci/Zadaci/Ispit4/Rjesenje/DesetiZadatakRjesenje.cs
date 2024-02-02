namespace DesetiZadatakIspit4
{
    /*Koji je oblikovni obrazac prikladan za rjesavanje zadatka danog u nastavku i u koju skupinu pripada? 
    Navedite strukture klasa te pripadajuce metode/atribute te koje biste koristili i njihove uloge*/

    /*
    Radite na sustavu za nadzor proizvodnje i potrošnje električne energije čija je primarna uloga 
    praćenje stanja ukupne proizvodnje i ukupne potrošnje energije. Postoji potreba da se više 
    različitih, raznorodnih komponenti sinkronizira s navedenim stanjima te bude automatski obaviješteno
    o pro- mjeni pri čemu se ovaj odnos mora moći ostvariti i prekinuti dinamički. Komponenta za 
    bilježenje (engl. logging) treba zabilježiti vrijednosti ovih avaju stanja pri svakoj izmjeni. 
    Komponenta za re- zervu (engl. backup) treba u slučaju da potrošnja skoči na 90% iznosa 
    proizvodnje, aktivirati dodatne kapacitete proizvodnje. Poznato je kako će u budućnosti biti
    potrebno dodati i nove komponente u ovaj sustav, a to mora biti moguće napraviti naknadno 
    bez utjecaja na klijentski kod.
    */
    /*
      +-----------------------+      +---------------------+      
  |       IObserver       |      |       ISubject      |      
  +-----------------------+      +---------------------+      
  | + Update(production,  |      | - production: double|      
  |     consumption)      |      | - consumption: double|      
  +-----------^-----------+      +-----------^-----------+      
              |                             |                   
  +-----------^-----------+      +-----------|-----------+                   
  | Logger, BackupSystem  |      |   EnergyMonitor      |                   
  +-----------------------+      +---------------------+                   
  |                       |      | + Attach(observer:  |                   
  | + Update(production,  |      |   IObserver): void   |                   
  |     consumption)      |      | + Detach(observer:  |                   
  |                       |      |   IObserver): void   |                   
  +-----------^-----------+      | + Notify(): void     |                   
                                 +---------------------+            
    */
}