﻿using System.Collections.Generic;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателях.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Количество всех покупателей.
        /// </summary>
        private static int _allCustomersCount;

        /// <summary>
        /// Уникальный идентификатор для всех объектов класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Корзина товаров.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Коллекция заказов.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Приоритетный покупатель.
        /// </summary>
        private bool _isPriority;

        /// <summary>
        /// Возвращает и задает количество всех покупателей.
        /// </summary>
        public static int AllCustomersCount
        {
            get => _allCustomersCount;
        }

        /// <summary>
        /// Возвращает и задает полное имя покупателя. Не более 200.
        /// </summary>
        public string FullName
        {
            get => (_fullName == null) ? null : _fullName;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthName, FullName);
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и создает адрес покупателя. Не более 200.
        /// </summary>
        public Address Address
        {
            get => (_address == null) ? null : _address;
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает уникальный индефикатор. Доступно только для чтения.
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Возвращает и задает корзину товаров.
        /// </summary>
        public Cart Cart
        {
            get { return _cart; }
            set { _cart = value; }
        }

        /// <summary>
        /// Возвращает и создает коллекцию заказов.
        /// </summary>
        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        /// Возвращает и задает булевое значение, является ли покупатель приоритетным или нет.
        /// </summary>
        public bool IsPriority
        {
            get => _isPriority;
            set => _isPriority = value;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            _allCustomersCount++;
            _id = _allCustomersCount;
            Cart = new Cart();
            Orders = new List<Order>();
            IsPriority = false;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullName">Полное имя покупателя. Не более 200 символов.</param>
        /// <param name="address">Адрес покупателя. Не более 200 символов.</param>
        /// <param name="cart">Корзина товаров.</param>
        /// <param name="orders">Коллекция товаров.</param>
        public Customer(string fullName, Address address, Cart cart, List<Order> orders, bool isPriority)
        {
            FullName = fullName;
            Address = address;
            Cart = cart;
            Orders = orders;
            _allCustomersCount++;
            _id = _allCustomersCount;
            IsPriority = isPriority;
        }
    }
}