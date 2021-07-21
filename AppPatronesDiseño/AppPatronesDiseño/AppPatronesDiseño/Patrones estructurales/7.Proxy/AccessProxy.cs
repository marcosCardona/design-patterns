
namespace AppPatronesDiseño.Patrones_estructurales._7.Proxy
{
    public class AccessProxy : IUserAccess, IVerifyAccess
    {
        private IUserAccess _UserAccess;

        /// <summary>
        /// Constructor
        /// </summary>
        public AccessProxy(IUserAccess userAccess)
        {
            _UserAccess = userAccess;
        }

        public string GetTokenAccess()
        {
            return _UserAccess.GetTokenAccess();
        }

        public bool VerifyAccess()
        {
            return Access.GetPermission(GetTokenAccess());
        }
    }
}