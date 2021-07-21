using System.Threading;
using System.Threading.Tasks;

namespace AppPatronesDiseño.Patrones_comportamiento._2.Command
{
    public class Command : ICommand
    {
        private EnumAction _Action;
        private Processor _Processor;

        public Command(Processor processor)
        {
            _Processor = processor;
        }

        public void Invoke()
        {
            switch (_Action)
            {
                case EnumAction.SleepThread:
                    Thread.Sleep(_Processor.SleepTime);
                    break;
                case EnumAction.RunAction:
                    Task.Run(_Processor.Action);
                    break;
                default:
                    break;
            }
        }

        public void SetAction(EnumAction action)
        {
            _Action = action;
        }
    }
}