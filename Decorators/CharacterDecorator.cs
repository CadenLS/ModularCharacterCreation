using ModularGameCharacterCreation.Models.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularGameCharacterCreation.Decorators
{
    public abstract class CharacterDecorator : IGameCharacter
    {
        protected IGameCharacter character;

        protected CharacterDecorator(IGameCharacter character)
        {
            this.character = character;
        }

        public virtual string Name => character.Name;
        public virtual string Display() => character.Display();
        public virtual string Attack() => character.Attack();
    }

}
