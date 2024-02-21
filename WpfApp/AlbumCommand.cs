using System;
using System.Windows.Input;

namespace WpfApp;

class AlbumCommand : ICommand
{
    readonly Func<bool> canExecute;

    readonly Action execute;

    public AlbumCommand(Action execute, Func<bool> canExecute = null)
    {
        this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
        this.canExecute = canExecute;
    }

    public event EventHandler CanExecuteChanged
    {
        add
        {
            if (canExecute != null)
                CommandManager.RequerySuggested += value;
        }
        remove
        {
            if (canExecute != null)
                CommandManager.RequerySuggested -= value;
        }
    }

    public bool CanExecute(object parameter) => canExecute is null || canExecute();

    public void Execute(object parameter) => execute();
}