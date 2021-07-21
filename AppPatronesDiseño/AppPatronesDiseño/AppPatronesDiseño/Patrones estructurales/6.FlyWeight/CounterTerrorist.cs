
namespace AppPatronesDiseño.Patrones_estructurales._6.FlyWeight
{
    public class CounterTerrorist : ICharacter
    {
        private readonly string _Name = "CounterTerrorist";

        public EnumTypeCharacter CharacterType => EnumTypeCharacter.CounterTerrorist;

        public string GetDescription()
        {
            return _Name;
        }

        public EnumTypeCharacter GetCharacterType()
        {
            return CharacterType;
        }
    }
}