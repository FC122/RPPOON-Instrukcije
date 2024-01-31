namespace IteratorZadatak
{
    public interface IIterator
    {
        public Item GetNext();
        public bool HasNext();
    }

    public interface IIteratorCollection
    {
        public IIterator CreateIterator();
    }

    public class Item
    {
        public string name;

        public Item(string name)
        {
            this.name = name;
        }
    }

    public class ItemIterator : IIterator
    {
        ItemCollection itemCollection;
        int Current;

        public ItemIterator(ItemCollection itemCollection)
        {
            this.itemCollection = itemCollection;
            Current = 0;
        }

        public Item GetNext()
        {
            Item item = itemCollection.GetItem(Current);
            Current++;
            return item;
        }

        public bool HasNext()
        {
            return Current >= itemCollection.Count();
        }
    }

    public class ItemCollection : IIteratorCollection
    {
        public List<Item> items;
        public ItemCollection()
        {
            items = new List<Item>();
        }
        public IIterator CreateIterator()
        {
            return new ItemIterator(this);
        }
        public Item GetItem(int index)
        {
            return items[index];
        }
        public int Count()
        {
            return items.Count;
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            ItemCollection itemCollection = new ItemCollection();

            itemCollection.items.Add(new Item("Static Shiv"));
            itemCollection.items.Add(new Item("BORK"));

            ItemIterator itemIterator = (ItemIterator)itemCollection.CreateIterator();

            itemCollection.items.Add(new Item("Rabadabadabidons"));

            itemCollection.items.ForEach(item =>
            {
                Console.WriteLine(item.name);
            });
        }
    }
}
