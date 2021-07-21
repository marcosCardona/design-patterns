
namespace AppPatronesDiseño.Patrones_estructurales._6.FlyWeight
{
    public interface ICharacter
    {
        EnumTypeCharacter CharacterType { get; }

        string GetDescription();
        EnumTypeCharacter GetCharacterType();
    }
}