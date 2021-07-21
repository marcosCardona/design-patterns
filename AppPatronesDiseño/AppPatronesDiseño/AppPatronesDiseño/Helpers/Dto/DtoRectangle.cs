using AppPatronesDiseño.Procesamiento;

namespace AppPatronesDiseño.Helpers.Dto
{
    public class DtoRectangle : IShape, IShapeArea
    {
        public DtoRectangle(int width, int height)
        {
            GetArea(width, height);
            Detail = $"{Shape} - {Corners} Corners - {Area} Area";
        }

        public string Shape { get; } = "Rectangle";
        public int Corners { get; } = 4;
        public string Detail { get; private set; }
        public int Area { get; private set; }

        public void GetArea(int width, int height)
        {
            Area = (width * height);
        }
    }
}