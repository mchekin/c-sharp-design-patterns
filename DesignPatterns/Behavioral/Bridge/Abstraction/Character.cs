using System;
using GangOfFour.Behavioral.Bridge.Implementer;

namespace GangOfFour.Behavioral.Bridge.Abstraction
{
    public abstract class Character
    {
        protected IWeapon Weapon { get; }

        protected Character(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public abstract int GetAttackForce();
    }
}