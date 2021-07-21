using System;

namespace AppPatronesDiseño.Patrones
{
    /// <summary>
    /// Principio de segregacion de interfaz
    /// Este principio indica que las interfaces no deberian tener
    /// La obligacion de implementar funcionalidades extensas
    /// Ejemplo: Tenemos como parametro una interfaz, el contrato es el mismo pero puede contener codigo nuevo
    /// </summary>
    public static class InterfaceSegregationPrinciple
    {
        /// <summary>
        /// Metodo para listar todas las clases que se heredan de una clase en especifico
        /// </summary>
        public static void ListarInterfacesHeredadas(Type t)
        {
            foreach (var type in t.GetInterfaces())
                Console.WriteLine(type.FullName);
        }
    }
}