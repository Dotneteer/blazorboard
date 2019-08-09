using Dotneteer.BlazorBoard.Client.Core;
using System;

namespace Dotneteer.BlazorBoard.Client.Services
{
    /// <summary>
    /// This class holds the event arguments for a state changed event
    /// </summary>
    public class StateChangedEventArgs: EventArgs
    {
        /// <summary>
        /// The old application state
        /// </summary>
        public BlazorBoardState OldState { get; }

        /// <summary>
        /// The new applications state
        /// </summary>
        public BlazorBoardState NewState { get; }

        public StateChangedEventArgs(BlazorBoardState oldState, BlazorBoardState newState)
        {
            OldState = oldState;
            NewState = newState;
        }
    }
}
