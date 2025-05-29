using ModularGameCharacterCreation.Models.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularGameCharacterCreation.Decorators
{
    public class SwordDecorator : CharacterDecorator
    {
        public SwordDecorator(IGameCharacter character) : base(character) { }

        public override string Attack()
        {
            return base.Attack() + "\nWith a shining sword!";
        }
    }
}
