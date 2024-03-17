using System.Windows.Input;

namespace TourPlanner.ViewModels
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> executeAction;
        private readonly Predicate<object> canExecutePredicate;
        public RelayCommand(Action<object> execute): this(execute,null){

        }
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            executeAction = execute;
            this.canExecutePredicate = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            return canExecutePredicate==null ? true: canExecutePredicate(parameter);
        }

        public void Execute(object? parameter)
        {
            executeAction(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value;}
        }


    }
}
