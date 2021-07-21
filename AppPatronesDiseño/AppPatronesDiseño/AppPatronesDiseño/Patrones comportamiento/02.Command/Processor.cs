using System;

namespace AppPatronesDiseño.Patrones_comportamiento._2.Command
{
    public class Processor
    {
        public Action Action { get; set; }
        public int SleepTime { get; set; }

        public void SetAction(Action action)
        {
            Action = action;
        }
        
        public void SetSleepTime(int sleepTime)
        {
            SleepTime = sleepTime;
        }
    }
}