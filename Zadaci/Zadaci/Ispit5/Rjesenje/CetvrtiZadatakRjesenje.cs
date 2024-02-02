/*
Na sto se odnosi pojam privremeni atributi kao miris u
kodu? Navedit nekoliko pristupa za refaktoriranje takvog mirisa.
*/
/*
Pojam "privremeni atributi" odnosi se na privremene
varijable ili podatkovne strukture koje se koriste 
samo za prolazne potrebe ili izračune unutar metoda 
ili funkcija, ali nemaju trajnu svrhu ili ne 
predstavljaju stvarno stanje objekta ili sustava. 
Takvi privremeni atributi često otežavaju razumijevanje 
koda, čine ga manje čitljivim i povećavaju rizik od 
grešaka.
*/

/*
Zamijenite privremene varijable izravnim korištenjem izraza 
ili vrijednosti tamo gdje se koriste.

Ako se privremeni atributi koriste unutar jednog dijela 
metode, razmislite o izdvajanju tog dijela koda u zasebnu 
metodu kako biste izbjegli upotrebu privremenih atributa 
izvan njihovog opsega
*/