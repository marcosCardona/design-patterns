using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AppPatronesDiseño.Patrones_estructurales._6.FlyWeight
{
    public class FactoryCharacter
    {
        private Dictionary<EnumTypeCharacter, ICharacter> _DictCharacter = new Dictionary<EnumTypeCharacter, ICharacter>();
        private readonly string _Namespace = typeof(ICharacter).Namespace;

        public void AddCharacter(EnumTypeCharacter typeCharacter)
        {
            if (!_DictCharacter.ContainsKey(typeCharacter))
            {
                // Obtener nombre completo de la clase
                var name = $"{_Namespace}.{typeCharacter}";
                // Crear nueva instancia de la clase requerida
                var character = Assembly.GetExecutingAssembly().CreateInstance(name);
                // Agregar instancia al diccionario
                _DictCharacter.Add(typeCharacter, character as ICharacter);
            }
        }

        public int GetTotalCountForType(EnumTypeCharacter typeCharacter)
        {
            return _DictCharacter.Where(w => w.Value.CharacterType == typeCharacter).Count();
        }

        public int GetTotalCount()
        {
            return _DictCharacter.Count;
        }
    }
}