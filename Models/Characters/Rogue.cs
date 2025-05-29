using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularGameCharacterCreation.Models.Characters
{
    // Rogue character implementation
    public class Rogue : IGameCharacter
    {
        public string Name => "Rogue";

        public string Display() => "A sneaky rogue appears.";

        public string Attack() => "Rogue strikes from the shadows!";
    }

}
