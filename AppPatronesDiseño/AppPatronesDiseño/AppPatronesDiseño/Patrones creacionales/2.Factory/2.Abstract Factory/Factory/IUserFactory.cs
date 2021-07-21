using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPatronesDiseño.Patrones_creacionales._2.Factory._2.Abstract_Factory
{
    public interface IUserFactory
    {
        EnumUserType GetUserType();
    }
}