using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfContacts.ViewModel;

namespace WpfContacts.View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает и задает выбранный контакт.
        /// </summary>
        public ContactVm SelectedContact
        {
            get { return (ContactVm)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        /// <summary>
        /// регистрирует свойство зависимостей для <see cref="SelectedContact"/>.
        /// </summary>
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("SelectedContact", typeof(ContactVm), 
                typeof(Control), new PropertyMetadata(null));

        private void NumberPhoneTextBoxValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[0-9()+-]");
            e.Handled = !regex.IsMatch(e.Text);
        }

        private void DataObject_OnPasting(object sender, DataObjectPastingEventArgs e)
        {
            string clipboard = e.DataObject.GetData(typeof(string)) as string;

            Regex regex = new Regex("[^0-9()+-]");
            if (regex.IsMatch(clipboard))
            {
                e.CancelCommand();
            }
        }
    }
}
