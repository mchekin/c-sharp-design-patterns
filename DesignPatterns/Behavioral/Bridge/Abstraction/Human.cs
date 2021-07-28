using GangOfFour.Behavioral.Bridge.Implementer;

namespace GangOfFour.Behavioral.Bridge.Abstraction
{
    public class Human : Character
    {
        public Human(IWeapon weapon) : base(weapon)
        {
        }

        public override int GetAttackForce()
        {
            return 2 + Weapon.GetAttackForce();
        }
    }
}