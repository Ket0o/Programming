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
    /// <summary>
    /// Хранит данные об адресе. 
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город (населенный пункт).
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает почтовый индекс. Должен содержать 6 цифр.
        /// </summary>
        public int Index
        {
            get => _index;
            set
            {
                Validator.CertainNumberDigits(nameof(Index), value, InitialConstants.DigitQuantityIndex);
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задает название страны/региона. Должно быть не более 50 символов.
        /// </summary>
        public string Country
        {
            get => (_country == null) ? null : _country;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthCountry, Country);
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задает название города (населенного пункта). Должно быть не более 50 символов.
        /// </summary>
        public string City
        {
            get => (_city == null) ? null : _city;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthCity, City);
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задает название улицы. Должно быть не более 100 символов.
        /// </summary>
        public string Street
        {
            get => (_street == null) ? null : _street;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthStreet, Street);
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер дома. Должно быть не более 10 символов.
        /// </summary>
        public string Building
        {
            get => (_building == null) ? null : _building;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthBuilding, Building);
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры/помещения. Должно быть не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get => (_apartment == null) ? null : _apartment;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthApartment, Apartment);
                _apartment = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс. Должен содержать 6 цифр.</param>
        /// <param name="country">Страна/регион. Должно быть не более 50 символов.</param>
        /// <param name="city">Город (населенный пункт). Должно быть не более 50 символов.</param>
        /// <param name="street">Улица. Должно быть не более 100 символов.</param>
        /// <param name="building">Номер дома. Должно быть не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры/помещения. Должно быть не более 10 символов.</param>
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