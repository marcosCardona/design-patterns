
namespace AppPatronesDiseño.Patrones_estructurales._7.Proxy
{
    public class Manager : IUserAccess
    {
        private EnumTypeRole _TypeRole = EnumTypeRole.Manager;

        public string GetTokenAccess()
        {
            return Access.GetAccessByTypeRole(_TypeRole);
        }
    }
}