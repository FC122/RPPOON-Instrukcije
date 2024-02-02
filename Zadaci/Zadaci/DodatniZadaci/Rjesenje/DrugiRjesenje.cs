/*
Za primjer dan izlistanjem kôda odredite obrazac o kojem 
je riječ i njegovu skupinu. Dopunite kôd implementacijom 
koja nedostaje te napišite klijentski kôd za ovaj primjer.
*/
/*Graditelj*/
namespace DrugiRjesenje
{
    enum Fruit
    {
        Apple,
        Banana,
        Orange
    }

    class FruitBasket
    {
        public Dictionary<Fruit, int> Contents { get; } = new Dictionary<Fruit, int>();
    }

    interface IFruitBasket
    {
        void AddFruit(Fruit fruit, int quantity);
        FruitBasket GetFruitBasket();
    }

    class StandardFruitBasketPackager : IFruitBasket
    {
        private FruitBasket basket = new FruitBasket();

        public void AddFruit(Fruit fruit, int quantity)
        {
            if (!basket.Contents.ContainsKey(fruit))
            {
                basket.Contents[fruit] = quantity;
            }
            else
            {
                basket.Contents[fruit] += quantity;
            }
        }

        public FruitBasket GetFruitBasket()
        {
            return basket;
        }
    }

    class FruitBasketPreSets
    {
        private IFruitBasket basket;

        public FruitBasketPreSets(IFruitBasket basket)
        {
            this.basket = basket;
        }

        public void MakeBasketForCustomer1()
        {
            basket.AddFruit(Fruit.Apple, 5);
            basket.AddFruit(Fruit.Banana, 3);
            basket.AddFruit(Fruit.Orange, 2);
        }

        public void MakeBasketForCustomer2()
        {
            basket.AddFruit(Fruit.Banana, 10);
            basket.AddFruit(Fruit.Orange, 5);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Kreiranje standardnog paketa voćne košarice
            IFruitBasket basket = new StandardFruitBasketPackager();

            // Postavljanje predefiniranih voćnih košarica za kupca 1
            FruitBasketPreSets preSets1 = new FruitBasketPreSets(basket);
            preSets1.MakeBasketForCustomer1();
            FruitBasket basketForCustomer1 = basket.GetFruitBasket();

            // Postavljanje predefiniranih voćnih košarica za kupca 2
            FruitBasketPreSets preSets2 = new FruitBasketPreSets(basket);
            preSets2.MakeBasketForCustomer2();
            FruitBasket basketForCustomer2 = basket.GetFruitBasket();
        }
    }
}