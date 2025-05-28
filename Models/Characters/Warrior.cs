using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularGameCharacterCreation.Models.Characters
{
    // Warrior character implementation
    public class Warrior : IGameCharacter
    {
        public string Name => "Warrior";

        public void Display() => Console.WriteLine("A strong warrior appears.");

        public void Attack() => Console.WriteLine("Warrior swings a mighty sword!");
    }

}
