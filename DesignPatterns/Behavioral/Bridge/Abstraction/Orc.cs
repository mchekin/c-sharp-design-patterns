using GangOfFour.Behavioral.Bridge.Implementer;

namespace GangOfFour.Behavioral.Bridge.Abstraction
{
    public class Orc : Character
    {
        public Orc(IWeapon weapon) : base(weapon)
        {
        }

        public override int GetAttackForce()
        {
            return 5 + Weapon.GetAttackForce();
        }
    }
}