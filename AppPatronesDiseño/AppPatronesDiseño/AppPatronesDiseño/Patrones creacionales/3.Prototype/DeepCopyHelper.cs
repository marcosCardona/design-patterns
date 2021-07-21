using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AppPatronesDiseño.Patrones_creacionales._3.Prototype
{
    public static class DeepCopyHelper
    {
        public static T DeepCopy<T>(this T value)
        {
            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                // Serializar parametro value
                formatter.Serialize(stream, value);

                // Realizar seek desde la posicion inicial
                stream.Seek(0, SeekOrigin.Begin);

                // Deserializar para obtener una copia
                object copy = formatter.Deserialize(stream);

                // Retornar generico
                return (T)copy;
            }
        }
    }
}