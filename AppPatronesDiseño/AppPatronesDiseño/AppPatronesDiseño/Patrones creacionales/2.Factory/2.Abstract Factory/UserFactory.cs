using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPatronesDiseño.Patrones_creacionales._2.Factory._2.Abstract_Factory
{
    public class UserFactory : IUserFactory
    {
        protected UserF _user;

        /// <summary>
        /// Constructor
        /// </summary>
        public UserFactory(UserF user)
        {
            _user = user;
        }

        public EnumUserType GetUserType() => _user.UserType;
    }
}