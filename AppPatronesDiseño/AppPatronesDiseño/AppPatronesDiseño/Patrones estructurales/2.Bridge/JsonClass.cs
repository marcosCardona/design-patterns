
namespace AppPatronesDiseño.Patrones_estructurales._2.Bridge
{
    public class JsonClass : BridgeFormatter
    {
        public string JsonCrude { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public JsonClass(IFormatter iFormatter) : base(iFormatter)
        {
        }

        public override string FormatString()
        {
            return base._iFormatter.Format(JsonCrude);
        }
    }
}