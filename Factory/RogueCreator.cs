using ModularGameCharacterCreation.Models.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularGameCharacterCreation.Factory
{
    public class RogueCreator : CharacterCreator
    {
        public override IGameCharacter CreateCharacter()
        {
            return new Rogue();
        }
    }

}
