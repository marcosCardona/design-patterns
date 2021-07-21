using System;
using System.Collections;
using System.Collections.Generic;

namespace AppPatronesDiseño.Patrones_comportamiento._4.Iterator
{
    public class AzureFaceCollection : ICollection<Face>
    {
        private List<Face> _ListFace = new List<Face>();

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public IIterator<Face> Iterator() => new AzureFaceIterator(_ListFace);

        public void Add(Face item)
        {
            _ListFace.Add(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Face item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Face[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Face> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Face item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}