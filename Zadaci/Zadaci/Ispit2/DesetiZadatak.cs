/*
Koji je oblikovni obrazac prikladan za rjesavanje zadatka danog u nastavku i u koju skupinu pripada
Navedite strukturu klasa te pripadajuce metode metode/atribute koje biste koristili i njihove uloge.
*/

/*
Radite na sustavu za analizu i praćenje proizvodnje električne energije. Trebate dizajnirati element
sustava koji prati ukupne iznose trenutne proizvodnje i trenutne potrošnje. U slučaju da dođe do 
značajnog rasta ili pada (određeno vrijednošću atributa) u proizvodnji ili potrošnji, potrebno je 
odmah poslati informacije različitim zainteresiranim stranama. Potrebno je omogućiti raznorodnim 
komponentama da reagiraju na promjene u proizvodnji i potrošnji, da mogu prestati reagirati ako 
tako odluče te osigurati da bude lako dodati nove takve komponente u sustav.
*/

/*

                                                            +------------------+
                                                            |     Client       |
                                                            +------------------+
                                                                    | uses
  +------------------------------+    implements    +------------------------------+
  |  ElectricitySystem           |<-----------------|  IElectricitySystem          |
  +------------------------------+                  +------------------------------+
  | -observers: Observer[]       |                  | + Detach(observer: IObserver)|
  +------------------------------+                  | + Attach(observer: IObserver)|
  | + Detach(observer: IObserver)|                  | + Notify()                   |   
  | + CurrentProduction: double  |                  +------------------------------+     
  | + Attach(observer: IObserver)|                  
  | + Notify()                   |                
  +------------------------------+                  
                <>
                |
                |  implements
                |
  +-------------------------------------------------+
  |     IObserver                                   |
  +-------------------------------------------------+
  | + Update(electricitySystem: IElectricitySystem) |
  +-------------------------------------------------+
                ^
                |
                |  observes
                |
  +-------------------------------------------------+
  | ElectricityChangeNotifier                       |
  +-------------------------------------------------+
  | + Update(electricitySystem: IElectricitySystem) |
  +-------------------------------------------------+

*/