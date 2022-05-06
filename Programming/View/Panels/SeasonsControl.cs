using System;
using System.Windows.Forms;
using Programming.Model.Enums;


namespace Programming.View.Panels
{
    public partial class SeasonsControl : UserControl
    {
        public SeasonsControl()
        {
            InitializeComponent();

            Array seasonValues = Enum.GetValues(typeof(Season));
            foreach (Season value in seasonValues)
            {
                SeasonNamesComboBox.Items.Add(value);
            }

            SeasonNamesComboBox.SelectedIndex = 0;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonNamesComboBox.SelectedItem)
            {
                case Season.Winter:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Бррр! Зима!");
                    break;
                case Season.Summer:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Ура! Лето!");
                    break;
                case Season.Spring:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Ура! Весна!");
                    break;
                case Season.Autumn:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("О нет! Осень!");
                    break;
            }
        }
    }
}
