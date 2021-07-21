using System.Collections.Generic;
using System.Drawing;

namespace AppPatronesDiseño.Patrones_comportamiento._9.State
{
    public class ProcessState
    {
        private Dictionary<EnumState, Color> _DictStates;
        private EnumState _ActualState;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProcessState()
        {
            // Set Ready
            _ActualState = EnumState.Ready;
            // Set new Dictionary
            _DictStates = new Dictionary<EnumState, Color>
            {
                [EnumState.Ready] = Color.Green,
                [EnumState.Processing] = Color.Red,
                [EnumState.Waiting] = Color.Yellow,
            };
        }

        public EnumState GetState()
        {
            return _ActualState;
        }

        public void SetState(EnumState state)
        {
            _ActualState = state;
        }

        public Color GetTrafficLight()
        {
            return _DictStates[_ActualState];
        }
    }
}