namespace StrategijaZadatak
{
    public class Enemy
    {
        int x;
        int y;

        public Enemy(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Spawn()
        {
            Console.WriteLine($"Spawn at {x} {y}");
        }
    }

    public interface ISpawnable
    {
        public void Spawn(int n);
    }

    public class RandomSpawn : ISpawnable
    {
        public void Spawn(int n)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                new Enemy(random.Next(-100, 100), random.Next(-100, 100));
            }
        }
    }

    public class DiagonalSpawn : ISpawnable
    {
        public void Spawn(int n)
        {
            for (int i = 0; i < n; i++)
            {
                new Enemy(i, i);
            }
        }
    }

    public class SpotSpawn : ISpawnable
    {
        public void Spawn(int n)
        {
            for (int i = 0; i < n; i++)
            {
                new Enemy(0, 0);
            }
        }
    }



    public class Game
    {
        ISpawnable spawnable;
        public Game(ISpawnable spawnable, int n)
        {
            this.spawnable = spawnable;
            Spawn(n);
        }

        public void SetSpawnWay(ISpawnable spawnable)
        {
            this.spawnable = spawnable;
        }

        public void Spawn(int n)
        {
            spawnable.Spawn(n);
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            new Game(new RandomSpawn(), 10);

            //logika
            new Game(new DiagonalSpawn(), 10);

            //logika
            new Game(new SpotSpawn(), 10);

        }
    }
}