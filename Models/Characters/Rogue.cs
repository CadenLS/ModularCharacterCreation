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

        public void Display() => Console.WriteLine("A sneaky rogue appears.");

        public void Attack() => Console.WriteLine("Rogue strikes from the shadows!");
    }

}
