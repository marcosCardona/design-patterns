
namespace AppPatronesDiseño.Patrones_creacionales._2.Factory._2.Abstract_Factory
{
    /// <summary>
    /// Clase Abstracta que define un contrato para todos los tipos de usuarios
    /// </summary>
    public abstract class UserF
    {
        public EnumUserType UserType;

        public abstract EnumUserType GetUserType();
    }
}