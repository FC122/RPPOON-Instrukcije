namespace DekoraterExtraRjesenje
{
    public interface IIngredient
    {
        public void Add();
    }

    public class Noodles : Base
    {
        public Noodles(IIngredient ingredient) : base(ingredient)
        {
        }

        public override void Add()
        {
            base.Add();
            Console.WriteLine("Add Noodles");
        }
    }

    public class Beef : Base
    {
        public Beef(IIngredient ingredient) : base(ingredient)
        {
        }

        public override void Add()
        {
            base.Add();
            Console.WriteLine("Add Beef");
        }
    }

    public class Mushrooms : Base
    {
        public Mushrooms(IIngredient ingredient) : base(ingredient)
        {
        }

        public override void Add()
        {
            base.Add();
            Console.WriteLine("Add Mushrooms");
        }
    }

    public class Base : IIngredient
    {
        IIngredient ingredient;
        public Base(IIngredient ingredient)
        {
            this.ingredient = ingredient;
        }

        public virtual void Add()
        {
            ingredient.Add();
        }
    }

    public class Water : IIngredient
    {
        public void Add()
        {
            Console.WriteLine("Add Water");
        }
    }

    public class Meal
    {
        IIngredient ingredient;
        public void MakeMushroomNoodleSoup()
        {
            ingredient = new Base(new Mushrooms(new Noodles(new Water())));
            ingredient.Add();
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            new Meal().MakeMushroomNoodleSoup();
        }
    }
}