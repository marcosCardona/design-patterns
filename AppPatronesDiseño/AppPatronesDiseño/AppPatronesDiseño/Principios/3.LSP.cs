using System;
using System.Collections.Generic;
using AppPatronesDiseño.Helpers.Dto;
using AppPatronesDiseño.Procesamiento;

namespace AppPatronesDiseño.Patrones
{
    /// <summary>
    /// Principio de sustitucion de Liskov
    /// Este principio es sobre mantener una clase base que funcione para 
    /// Todas las clases que la hereden con una funcionalidad estandar.
    /// Este principio no esta atado a la funcionalidad de una clase sino
    /// Mas bien a la estructura de las clases que interactuan entre si
    /// </summary>
    public static class LiskovSubstitutionPrinciple
    {
        /// <summary>
        /// Metodo para listas formas aplicando el principio LSP
        /// </summary>
        public static void EjemploListarFormas()
        {
            var listaFormas = new List<IShape>()
            {
                new DtoTriangle(),
                new DtoRectangle(10, 50),
                new DtoSquare(60, 60)
            };

            foreach (var forma in listaFormas)
                Console.WriteLine(forma.Detail);
        }
    }
}