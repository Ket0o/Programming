using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace View.ViewModel
{
    public class LoadCommand : ICommand
    {
        private MainVM mainVM;

        public LoadCommand(MainVM mainVM)
        {
            mainVM = mainVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mainVM.Load();
        }

        public event EventHandler CanExecuteChanged;
    }
}
