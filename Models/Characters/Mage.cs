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

        public void Display() => Console.WriteLine("A wise mage appears.");

        public void Attack() => Console.WriteLine("Mage casts a powerful spell!");
    }
}
