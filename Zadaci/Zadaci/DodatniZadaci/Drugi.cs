/*
Za primjer dan izlistanjem kôda odredite obrazac o kojem 
je riječ i njegovu skupinu. Dopunite kôd implementacijom 
koja nedostaje te napišite klijentski kôd za ovaj primjer.
*/
// namespace DrugiRjesenje
// {
//     interface IFruitBasket
//     {
//         void AddFruit(Fruit fruit, int quantity);
//         FruitBasket GetFruitBasket();
//     }
//     class StandardFruitBasketPackager : IFruitBasket
//     {
//         private FruitBasket basket = new FruitBasket();
//         public void AddFruit(Fruit fruit, int quantity)
//         {
//             if (!basket.Contents.ContainsKey(fruit))
//             {
//                 basket.Contents[fruit] = quantity;
//             }
//             else
//             {
//                 basket.Contents[fruit] += quantity;
//             }
//         }
//         public FruitBasket GetFruitBasket()
//         {
//             return basket;
//         }
//     }
//     class FruitBasketPreSets
//     {
//         private IFruitBasket basket;
//         public FruitBasketDirector(IFruitBasket basket)
//         {
//             this.basket = basket;
//         }
//         public void MakeBasketForCustomer1()
//         {
//             basket.AddFruit(Fruit.Apple, 5);
//             basket.AddFruit(Fruit.Banana, 3);
//             basket.AddFruit(Fruit.Orange, 2);
//         }
//         public void MakeBasketForCustomer2()
//         {
//             basket.AddFruit(Fruit.Banana, 10);
//             basket.AddFruit(Fruit.Orange, 5);
//         }
//     }
// }