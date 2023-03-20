using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace View.ViewModel
{
    public class SaveCommand : ICommand
    {
        //public event EventHandler? CanExecuteChanged;

        //private Action<object> execute;
        //private Func<object, bool> canExecute;

        //public SaveCommand(Action<object> execute, Func<object, bool> canExecute)
        //{
        //    this.execute = execute;
        //    this.canExecute = canExecute;
        //}

        //public bool CanExecute(object? parameter)
        //{
        //    return true;
        //}

        //public void Execute(object? parameter)
        //{
        //    this.execute(parameter);
        //}

        private MainVM mainVM;

        public SaveCommand(MainVM mainVM)
        {
            mainVM = mainVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mainVM.Save();
        }

        public event EventHandler? CanExecuteChanged;
    }
}
