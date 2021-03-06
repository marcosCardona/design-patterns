
namespace AppPatronesDiseño.Patrones_creacionales._2.Factory._2.Abstract_Factory
{
    /// <summary>
    /// Clase de alto nivel
    /// En esta clase estara toda la logica necesaria para el tipo de clase
    /// En este caso de tipo UserAdmin
    /// </summary>
    public class UserPro : UserF
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public UserPro()
        {
            this.UserType = EnumUserType.Pro;
        }

        public override EnumUserType GetUserType() => this.UserType;
    }
}