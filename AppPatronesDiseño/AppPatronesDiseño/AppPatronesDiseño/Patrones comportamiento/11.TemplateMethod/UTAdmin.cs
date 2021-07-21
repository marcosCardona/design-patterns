
namespace AppPatronesDiseño.Patrones_comportamiento._11.TemplateMethod
{
    public class UTAdmin : UserTemplate
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public UTAdmin()
        {
            base.Id = 1;
            base.Type = 1;
        }

        public override int GetUserId()
        {
            return base.Id;
        }

        public override bool HasAccess()
        {
            return true;
        }
    }
}