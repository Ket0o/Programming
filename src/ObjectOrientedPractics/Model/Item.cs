using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные товарах.
    /// </summary>
    public class Item
    {
        private static int _allItemsCount;

        private int _id;

        private string _name;

        private string _info;

        private double _cost;

        public static int AllItemsCount
        {
            get => _allItemsCount;
        }

        public string Name
        {
            get => (_name == null) ? null : _name;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthName, Name);
                _name = value;
            }
        }

        public string Info
        {
            get => (_info == null) ? null : _info;
            set
            {
                Validator.NoMoreThan(value, InitialConstants.MaxLengthInfo, Info);
                _info = value;
            }
        }

        public double Cost
        {
            get => _cost;
            set
            {
                Validator.AssertValueInRange(nameof(Cost), value, InitialConstants.MinValueCost, InitialConstants.MaxValueCost);
                _cost = value;
            }
        }

        public int Id
        {
            get => _id;
        }

        public Item()
        {
            _allItemsCount++;
            _id = _allItemsCount;
        }

        public Item(int id, string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _allItemsCount++;
            _id = _allItemsCount;
        }
    }
}
