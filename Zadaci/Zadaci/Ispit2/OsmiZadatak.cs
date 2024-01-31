/*Za primjer da izlistanjem koda odredite obrazac o kojem je rjec i njegovu skupinu.
    Dopunite kod implementacijom koja nedostaje te napisite klijentski kod za ovaj primjer*/
namespace OsmiZadatak
{
    public interface IAttack
    {
        int TotalDamage { get; }
    }

    public class PhysicalAttack : IAttack
    {
        private const int BoostFactor = 2;

        public PhysicalAttack(bool isBoosted, int damage)
        {
            IsBoosted = isBoosted;
            Damage = damage;
        }

        public bool IsBoosted { get; private set; }
        public int Damage { get; private set; }

        public int TotalDamage
        {
            get { return IsBoosted ? BoostFactor * Damage : Damage; }
        }
    }

    public class ComboAttack : IAttack
    {
        private List<IAttack> attacks = new List<IAttack>();

        public void Add(IAttack attack)
        {
            attacks.Add(attack);
        }

        public void Remove(IAttack attack)
        {
            attacks.Remove(attack);
        }

        public int TotalDamage
        {
            get
            {
                int totalDamage = 0;
                foreach (var attack in attacks)
                {
                    totalDamage += attack.TotalDamage;
                }
                return totalDamage;
            }
        }
    }

}