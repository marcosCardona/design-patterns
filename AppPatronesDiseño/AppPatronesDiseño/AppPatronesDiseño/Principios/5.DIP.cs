using AppPatronesDiseño.Helpers.Dto;
using AppPatronesDiseño.Procesamiento;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppPatronesDiseño.Principios
{
    /// <summary>
    /// Principio de inversion de dependencia
    /// Este principio dice que entre una clase de alto nivel y una de bajo nivel
    /// No deberia haber interferencia en ambas si se cambia el codigo en ellas
    /// Quiere decir que si hubo un cambio en una, no deberia afectar a las demas
    /// </summary>
    public class DependencyInversionPrinciple
    {
        private DtoTriangle _triangle { get; set; }
        private DtoRectangle _rectangle { get; set; }
        private DtoSquare _square { get; set; }
        public DtoTriangle triangle { get; set; }
        public DtoRectangle rectangle { get; set; }
        public DtoSquare square { get; set; }

        private List<IShape> _listaShape { get; set; }
        public List<IShape> listaShape { get; set; }

        /// <summary>
        /// Metodo constructor auxiliar
        /// </summary>
        public void Constructor(DtoTriangle tri, DtoRectangle rec, DtoSquare squ)
        {
            // Guardamos la lista original
            _triangle = tri;
            _rectangle = rec;
            _square = squ;
            // Setear lista en property publica
            triangle = _triangle;
            rectangle = _rectangle;
            square = _square;
        }

        /// <summary>
        /// Metodo constructor auxiliar
        /// </summary>
        public void Constructor(List<IShape> listaSha)
        {
            // Guardamos la lista original
            _listaShape = listaSha;
            // Setear lista en property publica
            listaShape = _listaShape;
        }

        /// <summary>
        /// Metodo para mostrar en pantalla la cantidad de objetos de tipo DtoRectangle
        /// </summary>
        public void ConteoTriangle()
        {
            Console.WriteLine($"1 Triangulo - Lados {new DtoTriangle().Corners}");
        }

        /// <summary>
        /// Metodo para mostrar en pantalla la cantidad de objetos de tipo DtoRectangle
        /// </summary>
        public void ConteoRectangle()
        {
            Console.WriteLine($"1 Rectangulo - Lados {new DtoRectangle(0, 0).Corners}");
        }

        /// <summary>
        /// Metodo para mostrar en pantalla la cantidad de objetos de tipo DtoRectangle
        /// </summary>
        public void ConteoSquare()
        {
            Console.WriteLine($"1 Cuadrado - Lados {new DtoSquare(0, 0).Corners}");
        }

        /// <summary>
        /// Metodo para mostrar en pantalla la cantidad de objetos de tipo DtoRectangle
        /// </summary>
        public void ConteoShape()
        {
            var listaFormasAgrupadas = listaShape.Select(s => s.Shape).Distinct().ToList();

            foreach (var forma in listaFormasAgrupadas)
            {
                // Obtener lista filtrada por forma
                var listaShapeFiltrada = listaShape.Where(w => w.Shape == forma);
                // Obtener primer elemento de la lista filtrada y buscar los lados
                var corners = listaShapeFiltrada.FirstOrDefault().Corners;

                // Mostrar resultado en pantalla
                Console.WriteLine($"{forma} - Cantidad: {listaShapeFiltrada.Count()} - Lados {corners}");
            }

            // Comentario
            Console.WriteLine("La desventaja de este principio es que no sabemos el tipo de objeto que estamos procesando");
            Console.WriteLine("Lo unico que sabemos con seguridad es que implementa la interfaz IShape");
        }
    }
}