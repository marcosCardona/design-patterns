using System.Collections.Generic;

namespace AppPatronesDiseño.Patrones_comportamiento._5.Memento
{
    public class Account : IMementoAction<Memento<int>>
    {
        private List<Memento<int>> _ListMemento = new List<Memento<int>>();
        private int _Balance;
        private int _Position;

        public Account()
        {
            _ListMemento.Add(new Memento<int>(0));
            _Balance = 0;
            _Position = 0;
        }

        public int GetBalance()
        {
            return _Balance;
        }

        public void Increase(int value)
        {
            _Balance += value;
            _Position++;

            _ListMemento.Add(new Memento<int>(_Balance));
        }

        public void Decrease(int value)
        {
            _Balance -= value;
            _Position++;

            _ListMemento.Add(new Memento<int>(_Balance));
        }

        public Memento<int> Undo()
        {
            if (_Position > 0)
            {
                // Cambiar position
                _Position--;
                // Obtener Memento
                var memento = _ListMemento[_Position];
                // Setear valor
                _Balance = memento.Value;

                return memento;
            }

            return null;
        }

        public Memento<int> Redo()
        {
            if (_ListMemento.Count > (_Position + 1))
            {
                // Cambiar position
                _Position++;
                // Obtener Memento
                var memento = _ListMemento[_Position];
                // Setear valor
                _Balance = memento.Value;

                return memento;
            }

            return null;
        }
    }
}