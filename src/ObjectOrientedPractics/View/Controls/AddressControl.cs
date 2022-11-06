using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;

        public AddressControl()
        {
            _address = new Address();

            InitializeComponent();
        }

        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
                SetValuesTextBoxes();
            }
        }

        private void SetValuesTextBoxes()
        {
            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(PostIndexTextBox.Text);
                _address.Index = index;
            }
            catch
            {
                PostIndexTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            PostIndexTextBox.BackColor = AppColors.CorrectColor;
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string country = CountryTextBox.Text;
                _address.Country = country;
            }
            catch
            {
                CountryTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            CountryTextBox.BackColor = AppColors.CorrectColor;
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string city = CityTextBox.Text;
                _address.City = city;
            }
            catch
            {
                CityTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            CityTextBox.BackColor = AppColors.CorrectColor;
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string street = StreetTextBox.Text;
                _address.Street = street;
            }
            catch
            {
                StreetTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            StreetTextBox.BackColor = AppColors.CorrectColor;
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string building = BuildingTextBox.Text;
                _address.Building = building;
            }
            catch
            {
                BuildingTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            BuildingTextBox.BackColor = AppColors.CorrectColor;
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string apartment = ApartmentTextBox.Text;
                _address.Apartment = apartment;
            }
            catch
            {
                ApartmentTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            ApartmentTextBox.BackColor = AppColors.CorrectColor;
        }

        public void ClearInfo()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();

            PostIndexTextBox.BackColor = AppColors.CorrectColor;
        }
    }
}
