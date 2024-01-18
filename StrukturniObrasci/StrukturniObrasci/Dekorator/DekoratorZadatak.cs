namespace DekoraterZadatak
{
    public class Effect
    {
        public void ApplyEffect()
        {
            Console.WriteLine("Apply Base Effect");
        }
    }
    public class HealthRegen
    {
        public void HealthRegenEffect()
        {
            Console.WriteLine("Health Regen");
        }
    }
    public class ArmorEffect
    {
        public void ArmorIncrease()
        {
            Console.WriteLine("Armor Increase");
        }
    }
    public class MagicDmg
    {
        public void IncreaseMagicDmg()
        {
            Console.WriteLine("Magic Dmg");
        }
    }
    public class Player
    {
        Effect effect;
        MagicDmg magicDmg;
        ArmorEffect armorEffect;
        HealthRegen healthRegen;
        public Player()
        {
            effect = new Effect();
            magicDmg = new MagicDmg();
            armorEffect = new ArmorEffect();
            healthRegen = new HealthRegen();
            effect.ApplyEffect();
            magicDmg.IncreaseMagicDmg();
            armorEffect.ArmorIncrease();
            healthRegen.HealthRegenEffect();
        }
    }

    public static class ClientCode
    {
        public static void Run()
        {
            new Player();
        }
    }
}