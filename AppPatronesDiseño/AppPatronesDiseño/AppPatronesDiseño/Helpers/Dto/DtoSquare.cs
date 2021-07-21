using AppPatronesDiseño.Procesamiento;

namespace AppPatronesDiseño.Helpers.Dto
{
    public class DtoSquare : IShapeArea, IShape
    {
        public DtoSquare(int width, int height)
        {
            GetArea(width, height);
            Detail = $"{Shape} - {Corners} Corners - {Area} Area";
        }

        public string Shape { get; } = "Square";
        public int Corners { get; } = 4;
        public string Detail { get; }
        public int Area { get; private set; }

        public void GetArea(int width, int height)
        {
            Area = (width * height);
        }
    }
}