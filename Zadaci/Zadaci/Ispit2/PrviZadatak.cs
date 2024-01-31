/*Dajte prijedloge preimenovanja za imena u danom 
izlistanju koda za koja smatrate da imaju nedostatke*/
namespace PrviZadatak
{
    class ProductObject
    {
        public string name { get; private set; } // prod. name
        public string price { get; private set; } // prod. price
        public bool InStock { get; set; } // flag - is prod. in stock or not?

        public ProductObject(string n, string p)
        {
            this.name = n;
            this.price = p;
            this.InStock = false;
        }
    }
    class HandlingOfProducts
    {
        List<ProductObject> prodsList; // List of prods.,

        public HandlingOfProducts(List<ProductObject> inv) // inventory of prods.
        {
            prodsList = inv;
        }

        public void revive(ProductObject product)
        {
            foreach (ProductObject prod in prodsList)
            { // make prod. available again
                if (product == prod)
                    prod.InStock = true;
            }
        }
        public void endAllUnavailable()
        { // expel the sold out products !!!
            prodsList.RemoveAll(product => product.InStock == false);
        }
    }
}