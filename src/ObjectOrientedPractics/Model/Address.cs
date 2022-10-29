using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Address
    {
        private int _index;

        private string _country;

        private string _city;

        private string _street;

        private string _building;

        private string _apartment;

        public int Index
        {
            get => _index;
            set
            {
                Validator.CertainNumberDigits(value, InitialConstants.DigitQuantityIndex);
                _index = value;
            }
        }

        public string Country
        {
            get => (_country == null) ? null : _country;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthCountry, Country);
                _country = value;
            }
        }

        public string City
        {
            get => (_city == null) ? null : _city;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthCity, City);
                _city = value;
            }
        }

        public string Street
        {
            get => (_street == null) ? null : _street;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthStreet, Street);
                _street = value;
            }
        }

        public string Building
        {
            get => (_building == null) ? null : _building;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthBuilding, Building);
                _building = value;
            }
        }

        public string Apartment
        {
            get => (_apartment == null) ? null : _apartment;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthApartment, Apartment);
                _apartment = value;
            }
        }

        public Address()
        {

        }

        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
    }
}