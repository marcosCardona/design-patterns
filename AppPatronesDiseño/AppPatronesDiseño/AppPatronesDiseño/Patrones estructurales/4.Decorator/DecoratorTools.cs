
namespace AppPatronesDiseño.Patrones_estructurales._4.Decorator
{
    public class DecoratorTools : Rol
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DecoratorTools(IRol iRol) : base(iRol)
        {
            _Rol = EnumRol.Tools;
        }
    }
}