﻿using System;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс реализует проверку валидации.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, чтобы строка по длине была не больше, чем максимально возможная длина.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="maxLength">Максимальная длина.</param>
        /// <param name="nameProperty">Название значения.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void NoMoreThan(string value, int maxLength, string nameProperty)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"the value of the {nameProperty} more than {maxLength}");
            }
        }

        /// <summary>
        /// Проверяет находиться ли значение типа double в диапозоне от одного числа до другого.
        /// </summary>
        /// <param name="nameProperty">Название значения.</param>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Левая граница диапозона.</param>
        /// <param name="max">Правая граница диапозона.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(string nameProperty, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"the value of the {nameProperty} field should be between {min} and {max} (inclusive)");
            }
        }

        public static void CertainNumberDigits(int value, int digitQuantity)
        {
            if (value.ToString().Length != digitQuantity)
            {
                throw new ArgumentException($"the value length must be equal to {digitQuantity}");
            }
        }
    }
}