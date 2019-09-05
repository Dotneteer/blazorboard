using Microsoft.AspNetCore.Components;
using System;

namespace Dotneteer.BlazorBoard.Client.Demos._03_DI.Scenario_04
{
    public abstract class MessengerAwareBase: ComponentBase, IDisposable
    {
        [Inject]
        protected IMessengerService Messenger { get; set; }

        private bool _eventSetup;

        protected override void OnParametersSet()
        {
            if (!_eventSetup)
            {
                Messenger.MessageSent += OnMessageReceived;
                _eventSetup = true;
            }
        }

        private void OnMessageReceived(object sender, Message msg)
        {
            OnMessage(msg);
        }

        protected virtual void OnMessage(Message msg)
        {
        }

        public void Dispose()
        {
            if (_eventSetup)
            {
                Messenger.MessageSent -= OnMessageReceived;
            }
        }
    }
}
