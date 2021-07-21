
namespace AppPatronesDiseño.Patrones_comportamiento._11.TemplateMethod
{
    public abstract class UserTemplate
    {
        public int Id { get; set; }
        public int Type { get; set; }

        public abstract int GetUserId();
        public abstract bool HasAccess();
    }
}