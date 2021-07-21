using System;
using System.Collections.Generic;

namespace AppPatronesDiseño.Patrones_estructurales._4.Decorator
{
    public class Rol : IRol
    {
        protected IRol _IRol;
        protected EnumRol _Rol;

        /// <summary>
        /// Constructor
        /// </summary>
        public Rol(IRol iRol)
        {
            _IRol = iRol;
        }

        public string GetRol()
        {
            return $"{_IRol.GetRol()}{Environment.NewLine}{_Rol}";
        }
    }
}