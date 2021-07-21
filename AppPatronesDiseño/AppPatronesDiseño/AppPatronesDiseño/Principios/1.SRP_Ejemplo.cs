using System.Collections.Generic;
using AppPatronesDiseño.Helpers;
using AppPatronesDiseño.Helpers.Dto;

namespace AppPatronesDiseño.Patrones
{
    public class SingleResponsabilityPrinciple_Ejemplo
    {
        public static List<DtoPrincipio> listaPatrones { get; set; }

        static SingleResponsabilityPrinciple_Ejemplo()
        {
            listaPatrones = new List<DtoPrincipio>();
        }

        public static void AgregarPatron(DtoPrincipio patron) => listaPatrones.Add(patron);
        public static void EliminarPatron(DtoPrincipio patron) => listaPatrones.Remove(patron);
        public static string ListarPatrones() { return listaPatrones.ListDtoPatronToString(); }
    }
}