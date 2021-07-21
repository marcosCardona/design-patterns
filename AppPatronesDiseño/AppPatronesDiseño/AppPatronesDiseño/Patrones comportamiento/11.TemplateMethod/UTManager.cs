
namespace AppPatronesDiseño.Patrones_comportamiento._11.TemplateMethod
{
    public class UTManager : UserTemplate
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public UTManager()
        {
            base.Id = 2;
            base.Type = 2;
        }

        public override int GetUserId()
        {
            return base.Id;
        }

        public override bool HasAccess()
        {
            return false;
        }
    }
}