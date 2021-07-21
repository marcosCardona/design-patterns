using System.Collections.Generic;

namespace AppPatronesDiseño.Patrones_comportamiento._4.Iterator
{
    public class AzureFaceIterator : IIterator<Face>
    {
        private List<Face> _ListFace;
        private int _Position = 0;

        public AzureFaceIterator(List<Face> listFace)
        {
            _ListFace = listFace;
        }

        public bool HasNext()
        {
            return (_ListFace.Count > _Position);
        }

        public Face Next()
        {
            _Position++;
            return _ListFace[_Position - 1];
        }
    }
}