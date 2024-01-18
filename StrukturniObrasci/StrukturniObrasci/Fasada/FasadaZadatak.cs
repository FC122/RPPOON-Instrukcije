namespace FasadaZadatak
{
    public class SpawnManger
    {
        public int mobs = 0;
        public void SpawnMob()
        {
            mobs++;
        }
        public void UnspawnMob()
        {
            mobs--;
        }
    }
    public class EnemyManager
    {
        public int enemies = 0;
        public void SpawnEnemie()
        {
            enemies++;
        }
    }
    public class EffectManager
    {
        public void MagicEffect()
        {
            Console.WriteLine("Magic");
        }
        public void FireEffect()
        {
            Console.WriteLine("Fire");
        }
        public void WaterEffect()
        {
            Console.WriteLine("Water");
        }
    }
}