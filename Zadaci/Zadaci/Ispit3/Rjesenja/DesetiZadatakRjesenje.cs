/*
Radite na sustavu u kojem je potrebno slati tekstualne poruke, 
ali je iz sigurnosnih razloga potrebno podržati kriptografske 
hash funkcije (algoritme). Riječ je o jednosmjernim funkcijama 
(ireverzibilne) koje iz podataka proizvoljne veličine generiraju 
niz bitova fiksne veličine. Potrebno je podržati različite inačice 
hash funkcija, a u budućnosti je vrlo vjerojatno da će, iz sigurnosnih
razloga, biti potrebno dodati i nove. Ove funkcije moraju biti 
izmjenjive tijekom izvodenja programa bez potrebe za ponovnim prevođenjem.
*/

/*Strategija*/

/*
    +-------------------------------------+     uses      +-------------------------------+
    |            IHashFunction            |<------------<>|      HashFunctionContext      |
    +-------------------------------------+               +-------------------------------+
    | + ComputeHash(input: string): string|               | - hashFunction: IHashFunction | 
    +-------------------------------------+               +-------------------------------+
              ^                                           | +DoTask()                     |
              |                                           +-------------------------------+
              |                                                 ^
              | implements                                      |
              |                                                 |
    +--------------------------------------+            +-----------------+
    |            MD5HashFunction           |<-----------|     Client      |
    +--------------------------------------+            +-----------------+
    | + ComputeHash(input: string): string |
    +--------------------------------------+
  


*/