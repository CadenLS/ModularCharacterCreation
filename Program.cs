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

            // Factory pattern
            CharacterCreator creator = charChoice switch
            {
                1 => new WarriorCreator(),
                2 => new MageCreator(),
                3 => new RogueCreator(),
                _ => throw new InvalidOperationException("Invalid selection")
            };

            IGameCharacter character = creator.CreateCharacter();

            Console.WriteLine($"\nYou have chosen: {character.Name}");

            // Decorator pattern
            Console.WriteLine("\nWould you like to add equipment?");
            Console.WriteLine("1. Sword");
            Console.WriteLine("2. Shield");
            Console.WriteLine("3. Both");
            Console.WriteLine("4. None");
            Console.Write("Enter the number: ");

            int equipChoice;
            while (!int.TryParse(Console.ReadLine(), out equipChoice) || equipChoice < 1 || equipChoice > 4)
            {
                Console.Write("Invalid input. Please enter 1, 2, 3, or 4: ");
            }

            character = equipChoice switch
            {
                1 => new SwordDecorator(character),
                2 => new ShieldDecorator(character),
                3 => new SwordDecorator(new ShieldDecorator(character)),
                _ => character
            };

            Console.WriteLine("\nCharacter Summary:");
            Console.WriteLine(character.Display());

            // Strategy pattern
            Console.WriteLine("\nChoose a combat strategy:");
            Console.WriteLine("1. Aggressive");
            Console.WriteLine("2. Defensive");
            Console.Write("Enter the number: ");

            int strategyChoice;
            while (!int.TryParse(Console.ReadLine(), out strategyChoice) || strategyChoice < 1 || strategyChoice > 2)
            {
                Console.Write("Invalid input. Please enter 1 or 2: ");
            }

            IAttackStrategy strategy = strategyChoice switch
            {
                1 => new AggressiveStrategy(),
                2 => new DefensiveStrategy(),
                _ => new AggressiveStrategy()
            };

            character = new StrategicCharacter(character, strategy);

            Console.Write("\nWould you like your character to attack? (y/n): ");
            string? attackInput = Console.ReadLine()?.Trim().ToLower();

            if (attackInput == "y")
            {
                Console.WriteLine("\n" + character.Attack());
            }
            else
            {
                Console.WriteLine("\nCharacter chooses not to attack");
            }

            Console.Write("\nWould you like to create another character? (y/n): ");
            string? input = Console.ReadLine()?.Trim().ToLower();

            keepGoing = input == "y";
            Console.WriteLine();
        }
    }
}
