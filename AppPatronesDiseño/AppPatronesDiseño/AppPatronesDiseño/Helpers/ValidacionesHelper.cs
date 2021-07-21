using AppPatronesDiseño.Helpers.Dto;
using System;

namespace AppPatronesDiseño.Helpers
{
    public static class ValidacionesHelper
    {
        /// <summary>
        /// Metodo para validar el objeto DtoPatron
        /// </summary>
        public static void ValidarPatron(DtoPrincipio patron, EnumPrincipios tipoPatron)
        {
            if (patron.Nombre != tipoPatron)
                throw new Exception();

            if (string.IsNullOrEmpty(patron.Detalle))
                throw new Exception();
        }
    }
}