using System;

namespace Dotneteer.BlazorBoard.Client.Demos._03_DI.Scenario_02
{
    public struct Message
    {
        public string Topic { get; }
        public string Text { get; }

        public Message(string topic, string text)
        {
            Topic = topic;
            Text = text;
        }
    }

    public interface IMessengerService
    {
        void SendMessage(Message msg);

        event EventHandler<Message> MessageSent;
    }

    public class MessengerService : IMessengerService
    {
        public void SendMessage(Message msg)
        {
            MessageSent?.Invoke(this, msg);
        }

        public event EventHandler<Message> MessageSent;
    }
}
