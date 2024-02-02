/*Dajte primjer pseudokoda koji narusava nacelo lisk substitution principle 
inversion te objasnite u cemu se to ogleda i zasto je to problem*/
namespace lsp
{
    class Rectangle
    {
        protected int width;
        protected int height;

        public void SetWidth(int width)
        {
            this.width = width;
        }

        public void SetHeight(int height)
        {
            this.height = height;
        }

        public int GetArea()
        {
            return width * height;
        }
    }

    class Square : Rectangle
    {
        public void SetWidth(int width)
        {
            this.width = width;
            this.height = width;
        }

        public void SetHeight(int height)
        {
            this.width = height;
            this.height = height;
        }
    }
    /*Ovaj pseudokod krši Liskov princip jer se koristi naslijeđivanje 
    klase Square od klase Rectangle, ali se ponašanje metoda koji 
    postavljaju širinu i visinu razlikuje između ta dva oblika.*/

    /*
    To predstavlja problem jer kôd koji koristi instancu Rectangle 
    može očekivati da se širina i visina mogu postaviti neovisno jedna
    o drugoj, dok to nije slučaj s instancom Square. Korištenje metoda
    SetWidth i SetHeight na instanci Square može dovesti do neočekivanih
    rezultata, kao što je promjena dimenzija koje bi mogle narusiti 
    invarijante ili očekivano ponašanje programa.
    */
}