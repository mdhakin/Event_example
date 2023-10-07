using System;

namespace Event_example
{
    public class EventExample
    {
        public delegate void DataReceived(object sender, EventArgs e, byte[] data);

        public event DataReceived DataReceivedEvent;

        /*
        ExampleEvent.DataReceivedEvent += DataReceivedEventHandlerMethod;
        private void DataReceivedEventHandlerMethod(object sender, EventArgs e, byte[] data)
        {
        }
         */
        public EventExample()
        {
            
        }

        public void testEvent()
        {
            byte[] bytes = { 1, 2, 3 };
            EventArgs args = new EventArgs();
            DataReceivedEvent?.Invoke(this, args, bytes);
        }
    }
}
