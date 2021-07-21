
namespace AppPatronesDiseño.Patrones_estructurales._4.Decorator
{
    public class DecoratorConfiguration : Rol
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DecoratorConfiguration(IRol iRol) : base(iRol)
        {
            _Rol = EnumRol.Configuration;
        }
    }
}