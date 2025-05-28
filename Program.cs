using ModularGameCharacterCreation.Decorators;
using ModularGameCharacterCreation.Factory;
using ModularGameCharacterCreation.Models.Characters;
using ModularGameCharacterCreation.Models.Strategy;
using System;

class Program
{
    static void Main()
    {
        bool keepGoing = true;

        while (keepGoing)
        {
            Console.WriteLine("Choose a character class:");
            Console.WriteLine("1. Warrior");
            Console.WriteLine("2. Mage");
            Console.WriteLine("3. Rogue");
            Console.Write("Enter the number: ");

            int charChoice;
            while (!int.TryParse(Console.ReadLine(), out charChoice) || charChoice < 1 || charChoice > 3)
            {
                Console.Write("Invalid input. Please enter 1, 2, or 3: ");
            }

            // 🎯 Use Factory Method pattern
            CharacterCreator creator = charChoice switch
            {
                1 => new WarriorCreator(),
                2 => new MageCreator(),
                3 => new RogueCreator(),
                _ => throw new InvalidOperationException("Invalid selection")
            };

            IGameCharacter character = creator.CreateCharacter();

            Console.WriteLine($"\nYou have chosen: {character.Name}");
            character.Display();
            character.Attack();

            Console.Write("\nWould you like to create another character? (y/n): ");
            string? input = Console.ReadLine()?.Trim().ToLower();

            keepGoing = input == "y";
            Console.WriteLine();
        }
    }


}