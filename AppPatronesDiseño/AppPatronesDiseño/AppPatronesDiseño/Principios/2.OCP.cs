using AppPatronesDiseño.Helpers.Dto;
using AppPatronesDiseño.Procesamiento;
using System;
using System.Collections.Generic;

namespace AppPatronesDiseño.Patrones
{
    /// <summary>
    /// Principio de abierto/cerrado
    /// Esta clase debe poder ser abierta a extensiones pero no a modificaciones
    /// Ejemplo: Tenemos como parametro una interfaz, el contrato es el mismo pero puede contener codigo nuevo
    /// </summary>
    public static class OpenClosedPrinciple
    {
        /// <summary>
        /// Metodo MostrarFormas
        /// Este es un buen ejemplo porque el metodo recibe como parametro una interfaz
        /// Por lo tanto las nuevas clases que hereden de la interfaz estaran sujetas al contrato
        /// Y podra ser consumido por este metodo sin problemas
        /// </summary>
        public static void MostrarFormas(IList<IShape> listaFormas)
        {
            foreach (var forma in listaFormas)
                Console.WriteLine($"{forma.Shape} - {forma.Corners} Corners");
        }

        /// <summary>
        /// Metodo MostrarFormas
        /// Este es un mal ejemplo porque el metodo recibe 3 parametros
        /// Cuando podria recibir uno solo
        /// </summary>
        public static void MostrarFormas(IList<DtoTriangle> listaTriangulo, IList<DtoRectangle> listaRectangulo, IList<DtoSquare> listaCuadrado)
        {
            foreach (var triangulo in listaTriangulo)
                Console.WriteLine($"{triangulo.Shape} - {triangulo.Corners} Corners");

            foreach (var rectangulo in listaRectangulo)
                Console.WriteLine($"{rectangulo.Shape} - {rectangulo.Corners} Corners");

            foreach (var cuadrado in listaCuadrado)
                Console.WriteLine($"{cuadrado.Shape} - {cuadrado.Corners} Corners");
        }
    }
}