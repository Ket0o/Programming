using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfContacts.ViewModel
{
    public class ErrorsVM : INotifyDataErrorInfo
    {
        private readonly Dictionary <string, List<string>> _propertyDependencies =
            new Dictionary<string, List<string>>();

        public bool HasErrors => _propertyDependencies.Any();

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public void AddError(string propertyName, string errorMessage)
        {
            if (!_propertyDependencies.ContainsKey(propertyName))
            {
                _propertyDependencies.Add(propertyName, new List<string>());
            }

            _propertyDependencies[propertyName].Add(errorMessage);
            OnErrorsChanged(propertyName);
        }

        public void ClearErrors(string propertyName)
        {
            if (_propertyDependencies.Remove(propertyName))
            {
                OnErrorsChanged(propertyName);
            }
        }

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        public IEnumerable GetErrors(string? propertyName)
        {
            return _propertyDependencies.GetValueOrDefault(propertyName, null);
        }
    }
}
