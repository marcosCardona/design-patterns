using AppPatronesDiseño.Helpers.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppPatronesDiseño.Helpers
{
    public static class FormatosHelper
    {
        /// <summary>
        /// Metodo para la conversion del tipo List<DtoPatron> a string
        /// </summary>
        public static string ListDtoPatronToString(this List<DtoPrincipio> listaPatrones)
        {
            if (listaPatrones?.Count > 0)
            {
                // Obtener lista formateada como string
                var listaPatronesString = listaPatrones.Select(s => $"{s.Nombre} - {s.Detalle}");
                // Retornar elementos de lista como un solo string
                return string.Join(Environment.NewLine, listaPatronesString);
            }

            return null;
        }
    }
}