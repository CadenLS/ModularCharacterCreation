using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularGameCharacterCreation.Models.Characters
{
    // Mage character implementation
    public class Mage : IGameCharacter
    {
        public string Name => "Mage";

        public string Display() => "A wise mage appears.";

        public string Attack() => "Mage casts a powerful spell!";
    }
}
