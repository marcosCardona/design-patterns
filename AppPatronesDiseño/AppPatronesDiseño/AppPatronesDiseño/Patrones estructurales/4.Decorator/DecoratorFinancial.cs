
namespace AppPatronesDiseño.Patrones_estructurales._4.Decorator
{
    public class DecoratorFinancial : Rol
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public DecoratorFinancial(IRol iRol) : base(iRol)
        {
            _Rol = EnumRol.Financial;
        }
    }
}