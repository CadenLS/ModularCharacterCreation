using ModularGameCharacterCreation.Models.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularGameCharacterCreation.Decorators
{
    public class ShieldDecorator : CharacterDecorator
    {
        public ShieldDecorator(IGameCharacter character) : base(character) { }

        public override string Display()
        {
            return base.Display() + "\nCarrying a strong shield.";
        }
    }
}
