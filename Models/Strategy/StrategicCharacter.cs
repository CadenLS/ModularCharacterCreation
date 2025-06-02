using ModularGameCharacterCreation.Models.Characters;

namespace ModularGameCharacterCreation.Models.Strategy
{
    public class StrategicCharacter : IGameCharacter
    {
        private IGameCharacter character;
        private IAttackStrategy strategy;

        public StrategicCharacter(IGameCharacter character, IAttackStrategy strategy)
        {
            this.character = character;
            this.strategy = strategy;
        }

        public string Name => character.Name;

        public string Display()
        {
            return character.Display();
        }

        public string Attack()
        {
            return $"{character.Attack()} {strategy.Execute()}";
        }

        public void SetStrategy(IAttackStrategy newStrategy)
        {
            strategy = newStrategy;
        }
    }
}
