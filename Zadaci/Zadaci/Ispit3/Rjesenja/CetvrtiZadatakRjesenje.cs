/*
Na sto se odnosi pojam privremeni atributi kao miris u
kodu? Navedit nekoliko pristupa za refaktoriranje takvog mirisa.
*/

/*
Privremeni atributi, kao miris u kodu, odnose se na privremene varijable
ili atribute koji se koriste samo za privremene potrebe ili izračune, ali
nemaju jasnu svrhu ili ulogu u kontekstu klase ili metode u kojoj se nalaze.
Takvi atributi mogu otežati čitanje i razumijevanje koda, te otežati održavanje
i daljnji razvoj.
*/

/*
Pristupi refaktoriranja:
Preoblikovanje u lokalne varijable: Ako je moguće, privremene atribute možete
preoblikovati u lokalne varijable unutar metode ili bloka koda gdje se koriste.
To će smanjiti opseg varijable i poboljšati čitljivost koda.

Izdvajanje u zasebnu metodu: Ako je privremeni atribut dio složenog izračuna ili
operacije, možete razmotriti izdvajanje tog izračuna u zasebnu metodu. To će
jasno definirati svrhu i ulogu izračuna, olakšati testiranje i omogućiti ponovnu 
upotrebu koda.
*/
