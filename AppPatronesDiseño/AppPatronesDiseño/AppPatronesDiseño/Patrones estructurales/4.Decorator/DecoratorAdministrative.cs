
namespace AppPatronesDiseño.Patrones_estructurales._4.Decorator
{
    public class DecoratorAdministrative : Rol
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DecoratorAdministrative(IRol iRol) : base(iRol)
        {
            _Rol = EnumRol.Administrative;
        }
    }
}