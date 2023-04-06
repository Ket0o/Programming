using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;
using View.Model.Services;
using View.Model;
using View.ViewModel.Base;

namespace View.ViewModel
{
    public class LoadCommand : Command
    {
        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            ContactSerializer.Deserialize();
        }
    }
}
