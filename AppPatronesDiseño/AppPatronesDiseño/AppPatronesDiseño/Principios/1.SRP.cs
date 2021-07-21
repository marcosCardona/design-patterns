using AppPatronesDiseño.Helpers;
using AppPatronesDiseño.Helpers.Dto;
using System;

namespace AppPatronesDiseño.Patrones
{
    /// <summary>
    /// Principio de una sola responsabilidad
    /// Esta clase debe contar con un metodo que tenga una sola responsabilidad
    /// Ejemplo: Agregar algun registro a la BD, Validar campos
    /// No deberia tener mas de una responsabilidad porque viola el principio establecido
    /// </summary>
    public class SingleResponsibilityPrinciple
    {
        /// <summary>
        /// Metodo MostrarMensaje
        /// Este es un buen ejemplo porque el metodo tiene 1 responsabilidad
        /// 1- Mostrar mensaje en pantalla
        /// </summary>
        public void MostrarMensaje(DtoPrincipio patron)
        {
            // Validacion del objeto DtoPatron
            ValidacionesHelper.ValidarPatron(patron, EnumPrincipios.SingleResponsibilityPrinciple);
            // Mensaje final
            Console.WriteLine($"Mensaje del patron {patron.Nombre}");
        }

        /// <summary>
        /// Metodo MostrarMensaje
        /// Este es un mal ejemplo porque el metodo tiene 2 responsabilidades
        /// 1- Verificar que el mensaje posea algun valor
        /// 2- Mostrar mensaje en pantalla
        /// </summary>
        public void MostrarMensaje(string mensaje)
        {
            if (!string.IsNullOrEmpty(mensaje))
                Console.WriteLine("Mensaje del patron SingleResponsabilityPrinciple - Este es un mal ejemplo");
        }

        /// <summary>
        /// Metodo MostrarMensaje
        /// Este es un mal ejemplo porque el metodo tiene 2 responsabilidades
        /// 1- Verificar que el detalle del objeto DtoPatron posea algun valor
        /// 2- Mostrar detalle en pantalla
        /// </summary>
        //public void MostrarMensaje(DtoPatron patron)
        //{
        //    if (!string.IsNullOrEmpty(patron.Detalle))
        //        Console.WriteLine("Mensaje del patron SingleResponsabilityPrinciple - Este es un mal ejemplo");
        //}
    }
}