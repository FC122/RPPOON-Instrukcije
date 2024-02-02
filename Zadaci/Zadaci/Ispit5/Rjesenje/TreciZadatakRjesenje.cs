/*Dajte primjer pseudokoda koji narusava nacelo SRP 
te objasnite u cemu se to ogleda i zasto je to problem*/

namespace TreciZadatakRjesenjeIspit5
{
    public class User { }
    //Klasa za upravljanje korisničkim podacima:
    public class UserManager
    {
        public void addUser(User user)
        {
            // Dodavanje korisnika u bazu podataka
            // Slanje e-mail poruke o uspješnom dodavanju korisnika
        }

        public void deleteUser(User user)
        {
            // Brisanje korisnika iz baze podataka
            // Slanje e-mail poruke o uspješnom brisanju korisnika
        }

        public void updateUser(User user)
        {
            // Ažuriranje podataka korisnika u bazi podataka
            // Slanje e-mail poruke o uspješnoj izmjeni podataka korisnika
        }
    }
}
/*
Ovaj pseudokod krši načelo jedinstvene odgovornosti (SRP) jer klasa UserManager 
ima više od jedne odgovornosti. Osim što upravlja korisničkim podacima, također je 
odgovorna za slanje e-mail poruka. To otežava održavanje koda i dovodi do problema pri 
promjeni ili proširenju sustava. Umjesto toga, trebalo bi razdvojiti odgovornosti, na 
primjer, stvaranjem zasebne klase ili servisa za slanje e-mail poruka.
*/