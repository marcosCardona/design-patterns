
namespace AppPatronesDiseño.Patrones_estructurales._2.Bridge
{
    public class XmlClass : BridgeFormatter
    {
        public string XmlCrude { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public XmlClass(IFormatter iFormatter) : base(iFormatter)
        {
        }

        public override string FormatString()
        {
            return base._iFormatter.Format(XmlCrude);
        }
    }
}