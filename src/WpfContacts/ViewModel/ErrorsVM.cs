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
    /// <summary>
    /// Представляет базовую реализацию интерфейса <see cref="INotifyDataErrorInfo"/>.
    /// </summary>
    public class ErrorsVM : INotifyDataErrorInfo
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly Dictionary <string, List<string>> _propertyDependencies =
            new Dictionary<string, List<string>>();

        /// <summary>
        /// 
        /// </summary>
        public bool HasErrors => _propertyDependencies.Any();

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="errorMessage"></param>
        public void AddError(string propertyName, string errorMessage)
        {
            if (!_propertyDependencies.ContainsKey(propertyName))
            {
                _propertyDependencies.Add(propertyName, new List<string>());
            }

            _propertyDependencies[propertyName].Add(errorMessage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        public void ClearErrors(string propertyName)
        {
            if (_propertyDependencies.Remove(propertyName))
            {
                OnErrorsChanged(propertyName);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public IEnumerable GetErrors(string? propertyName)
        {
            return _propertyDependencies.GetValueOrDefault(propertyName, null);
        }
    }
}
