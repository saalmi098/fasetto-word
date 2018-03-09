using System;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// A basic command that runs an action
    /// </summary>
    public class RelayParameterizedCommand : ICommand
    {
        /// <summary>
        /// The action to run
        /// </summary>
        private Action<object> mAction;

        /// <summary>
        /// The event that fires when the <see cref="CanExecute(object)"/> value has changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public RelayParameterizedCommand(Action<object> action)
        {
            mAction = action;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            mAction?.Invoke(parameter);
        }
    }
}
