/*
Koji je oblikovni obrazac prikladan za rjesavanje zadatka danog u nastavku i u koju skupinu pripada
Navedite strukturu klasa te pripadajuce metode metode/atribute koje biste koristili i njihove uloge.
*/

/*
Radite na postojećem sustavu za dohvaćanje izvješća o greškama (engl. bug) s udaljenog poslužitelja 
i njihov prikaz. Klijentska klasa koja predstavlja repozitorij izvješća dobiva ih upora- bom sučelja
 IBugReport Provider i njegove metode List<BugReport> GetBugReports (Severity severity). 
 Do sada je korištena konkretna klasa BugApi Service koja implementira dano sučelje. Pojavila se 
 potreba da sustav podrži novu klasu za pružanje ovih informacija, imena BugsBuster, koja dolazi 
 kao dio vanjske biblioteke, a ne ugrađuje niti može ugraditi dano sučelje. Prototip me- tode koju 
 pruža BugsBuster je List<BugInfo> RetrieveAll(). Klijentski kod ne treba biti svjestan promjene 
 konkretne klase.
*/