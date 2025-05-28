using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularGameCharacterCreation.Models.Characters
{
    // Interface for game characters holding common properties and methods
    public interface IGameCharacter
    {
        string Name { get; }
        void Display();
        void Attack();
    }
}
