namespace StrategijaRjesenje
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

    public interface ISpawnWay
    {
        public void Spawn(int n);
    }

    public class RandomSpawn : ISpawnWay
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

    public class DiagonalSpawn : ISpawnWay
    {
        public void Spawn(int n)
        {
            for (int i = 0; i < n; i++)
            {
                new Enemy(i, i);
            }
        }
    }

    public class SpotSpawn : ISpawnWay
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
        ISpawnWay spawnWay;
        public Game(ISpawnWay spawnWay, int n)
        {
            this.spawnWay = spawnWay;
            spawnWay.Spawn(n);
        }
        public void SetSpawnWay(ISpawnWay spawnWay)
        {
            this.spawnWay = spawnWay;
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