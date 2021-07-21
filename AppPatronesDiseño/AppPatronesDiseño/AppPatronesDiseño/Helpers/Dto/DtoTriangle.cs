using AppPatronesDiseño.Procesamiento;

namespace AppPatronesDiseño.Helpers.Dto
{
    public class DtoTriangle : IShape
    {
        public DtoTriangle()
        {
            Detail = $"{Shape} - {Corners} Corners";
        }

        public string Shape { get; } = "Triangle";
        public int Corners { get; } = 3;
        public string Detail { get; }
    }
}