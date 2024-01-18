namespace ProxyZadatak
{
    public interface IEnemySpawner
    {
        public void SpawnEnemies();
    }
    public abstract class Enemy
    {
        public abstract void Spawn();
    }
    public class Zombie : Enemy
    {
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

    public class Game
    {
        //Dali je potrebno instancirati enemije prije koristenja?
        EnemySpawner enemySpawner =
            new EnemySpawner(new List<Enemy>(){
                new Zombie(),new Zombie(),
                new Zombie(),new Zombie(),
                new Zombie()
            });
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