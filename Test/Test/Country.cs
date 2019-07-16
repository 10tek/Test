using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Country
    {
        private const int ZERO = 0;
        private string _countryName;
        private Field[] _fields;
        private int _capacity;
        private static int numberForName = 0;
        public Field this[int index]
        {
            get
            {
                return _fields[index];
            }
            set
            {
                _fields[index] = value;
            }
        }

        public int GetSize()
        {
            return _capacity;
        }

        public void SetName(string countryName)
        {
            _countryName = countryName;
        }

        public string GetName()
        {
            return _countryName;
        }

        public Country()
        {
            _capacity = ZERO;
            _fields = new Field[ZERO];
            _countryName = "Страна" + ++numberForName;
        }

        public Country(string countryName)
        {
            _capacity = ZERO;
            _fields = new Field[ZERO];
            _countryName = countryName;
        }

        public void AddField()
        {
            Array.Resize(ref _fields, ++_capacity);
        }
    }
}
