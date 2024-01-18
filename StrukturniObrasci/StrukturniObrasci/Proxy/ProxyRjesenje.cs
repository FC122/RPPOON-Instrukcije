namespace ProxyRjesenje
{
    public interface ICloneable
    {
        public object Clone();
    }
    public interface IEnemySpawner
    {
        public void SpawnEnemies();
    }
    public abstract class Enemy : ICloneable
    {
        public virtual object Clone()
        {
            throw new NotImplementedException();
        }
        public abstract void Spawn();
    }
    public class Zombie : Enemy, ICloneable
    {
        public object Clone()
        {
            return new Zombie();
        }
        public override void Spawn()
        {
            Console.WriteLine("Zombie is spawned");
        }
    }
    public class EnemySpawner : IEnemySpawner
    {
        List<Enemy> enemies;
        public EnemySpawner(List<Enemy> enemies)
        {
            if (enemies.Count() < 5)
            {
                throw new Exception("Not enough enemies");
            }
            else
            {
                this.enemies = enemies;
            }
        }
        public void SpawnEnemies()
        {
            enemies.ForEach(enemie => enemie.Spawn());
        }
    }

    public class ProxySpawner : IEnemySpawner
    {
        IEnemySpawner enemySpawner;
        int enemiesCount;
        Enemy enemyReference;
        public ProxySpawner(int enemiesCount, Enemy enemyReference)
        {
            if (enemiesCount < 5)
            {
                throw new Exception("Not enough enemies");
            }
            else
            {
                this.enemiesCount = enemiesCount;
                this.enemyReference = enemyReference;
            }
        }
        public void SpawnEnemies()
        {
            List<Enemy> enemies = new List<Enemy>();
            for (int i = 0; i < enemiesCount; i++)
            {
                //We are now doing instantiation when it is needed
                enemies.Add((Enemy)enemyReference.Clone());
            }
            enemySpawner = new EnemySpawner(enemies);
            enemySpawner.SpawnEnemies();
        }
    }

    public class Game
    {
        //Dali je potrebno instancirati enemije prije koristenja?
        IEnemySpawner enemySpawner = new ProxySpawner(5, new Zombie());
        public Game()
        {
            enemySpawner.SpawnEnemies();
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            new Game();
        }
    }
}