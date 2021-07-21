
namespace AppPatronesDiseño.Patrones_estructurales._6.FlyWeight
{
    public class Terrorist : ICharacter
    {
        private readonly string _Name = "Terrorist";

        public EnumTypeCharacter CharacterType => EnumTypeCharacter.Terrorist;

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