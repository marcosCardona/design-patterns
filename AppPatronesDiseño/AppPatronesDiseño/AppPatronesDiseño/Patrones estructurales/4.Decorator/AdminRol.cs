using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPatronesDiseño.Patrones_estructurales._4.Decorator
{
    public class AdminRol : IRol
    {
        public string GetRol()
        {
            return EnumRol.Basic.ToString();
        }
    }
}