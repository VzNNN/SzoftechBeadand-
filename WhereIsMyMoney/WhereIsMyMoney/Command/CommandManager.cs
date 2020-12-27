using System;
using System.Windows.Input;

namespace WhereIsMyMoney.Command
{
    public class CommandManager : ICommand
    {
        private Action action;
        public event EventHandler CanExecuteChanged = (sender, e) => { };
        public CommandManager(Action action) => this.action = action;
        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter) => action();
    }
}
