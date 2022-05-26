using System;

namespace ListOfEmployees.Model.Classes
{
    public static class Validator
    {
        public static void NoMoreThan(string value, int maxLength, string nameProperty)
        {
            if(value.Length > maxLength)
            {
                throw new ArgumentException($"the value of the {nameProperty} more than {maxLength}");
            }
        }
        /// <summary>
        /// Проверяет, чтобы значение типа int было положительным.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="nameProperty">Название значения.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(int value, string nameProperty)
        {
            if (value < 0)
            {
                throw new ArgumentException($"the value of the {nameProperty} field must be positive");
            }
        }
        /// <summary>
        /// Проверяет находиться ли значение типа int в диапозоне от одного числа до другого.
        /// </summary>
        /// <param name="nameProperty">Название значения.</param>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Левая граница диапозона.</param>
        /// <param name="max">Правая граница диапозона.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(string nameProperty, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"the value of the {nameProperty} field should be between {min} and {max} (inclusive)");
            }
        }
        public static void NoMoreThan(DateTime value, string nameProperty)
        {
            if(value > DateTime.Today)
            {
                throw new ArgumentException ($"the value of the {nameProperty} more than {DateTime.Today}");
            }
        }
    }
}
