﻿namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о максимальных и минимальных константах
    /// </summary>
    public static class InitialConstants
    {
        /// <summary>
        /// Путь к appdata для items
        /// </summary>
        public const string SerializerResultItems = @"\ItemSerialize.json";

        /// <summary>
        /// Путь к appdata для 
        /// </summary>
        public const string SerializerResultCustomers = @"\CustomerSerialize.json";

        /// <summary>
        /// Максимальное количество символов для <see cref="Item.Name"/>.
        /// </summary>
        public const int MaxLengthName = 200;

        public const int MaxLengthCountry = 50;

        public const int MaxLengthCity = 50;

        public const int MaxLengthStreet = 100;

        public const int MaxLengthBuilding = 10;

        public const int MaxLengthApartment = 10;

        /// <summary>
        /// Максимальное количество символов для <see cref="Customer.Address"/>
        /// </summary>
        public const int MaxLengthAddress = 200;

        /// <summary>
        /// Максимальное количество символов для <see cref="Item.Info"/>
        /// </summary>
        public const int MaxLengthInfo = 1000;

        /// <summary>
        /// Минимальное количество символов для <see cref="Item.Cost"/>
        /// </summary>
        public const double MinValueCost = 0;

        /// <summary>
        /// Максимальное количество символов для <see cref="Item.Cost"/>
        /// </summary>
        public const double MaxValueCost = 100000;

        public const int DigitQuantityIndex = 6;
    }
}
