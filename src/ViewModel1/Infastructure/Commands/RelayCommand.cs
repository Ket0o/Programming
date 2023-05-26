using System;
using System.Windows.Input;

namespace ViewModel.Infastructure.Commands
{
    /// <summary>
    /// Предоставляет базовую реализацию ICommand интерфейса.
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// Событие изменения возможности вызова команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <summary>
        /// Делегат для вызова команды.
        /// </summary>
        private readonly Action<object> _execute;

        /// <summary>
        /// Делегат проверки, для вызова команды.
        /// </summary>
        private readonly Func<object, bool> _canExecute;

        /// <summary>
        /// Создает экземпляр класса <see cref="RelayCommand"/>
        /// </summary>
        /// <param name="execute">Делегат для вызова команды.</param>
        /// <param name="canExecute">Делегат проверки, для вызова команды.</param>
        /// <exception cref="ArgumentNullException">Вызывается, если получаем null.</exception>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        /// <summary>
        /// Определяет, может ли команда выполняться.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>Возвращает true, если кто-то подписался на событие и false, если нет.</returns>
        public bool CanExecute(object? parameter)
        {
            return _canExecute?.Invoke(parameter) ?? true;
        }

        /// <summary>
        /// Выполняет реализацию команды.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
