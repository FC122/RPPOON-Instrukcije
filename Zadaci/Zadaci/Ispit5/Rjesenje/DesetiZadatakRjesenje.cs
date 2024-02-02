/*
Koji je oblikovni obrazac prikladan za rjesavanje zadatka danog u nastavku i 
u koju skupinu pripada. Navedite strukturu klasa te pripadajuce metode 
metode/atribute koje biste koristili i njihove uloge.
*/

/*
Radite na alatu namijenjenom djeci s posebnim potrebama u komunikaciji koji
će omogućiti prikaz različitih oblika na ekranu. Postoji više različitih 
konkretnih oblika (npr. kružnica, pravokutnik) koje će biti potrebno podržati, 
a uz konkretne oblike postoje i složeni oblici koji se sastoje od više osnovnih 
ili čak više drugih kompleksnih oblika. Bez obzira o kakvom je obliku riječ, 
klijentski kôd očekuje funkcionalnost iscrtavanja i funkcionalnost određivanja
krajnje lijeve, desne i gornje točke na obliku.
*/

/*
  +-------------------+
  |       Shape       |<--------------------------+       
  +-------------------+                           |
  | +Draw(): void     |                           |
  | +GetLeft(): Point |                           |
  | +GetRight(): Point|                           |
  | +GetTop(): Point  |                           |   
  +---------+---------+                           |
            ^---------------------+               |
            |                     |               |
  +---------+---------+ +---------+---------+     |
  |   SimpleShape     | |   ComplexShape    | <>--|            
  +-------------------+ +-------------------+
  | ...               | | - shapes:Shape[]  |
  +-------------------+ +-------------------+
*/