using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Field
    {
        private const int ZERO = 0;
        private Culture[] _cultures;
        private int _capacity;

        public Culture this[int index]
        {
            get
            {
                return _cultures[index];
            }
            set
            {
                _cultures[index] = value;
            }
        }

        public int GetSize()
        {
            return _capacity;
        }

        public Culture GetCulture(int index)
        {
            return _cultures[index];
        }

        public Field()
        {
            _capacity = ZERO;
            _cultures = new Culture[ZERO];
        }

        public void AddCulture(string name, string plan)
        {
            Array.Resize(ref _cultures, ++_capacity);
            _cultures[_capacity - 1] = new Culture(name, plan);
        }
        
        public void SetCultureName(int index, string name)
        {
            _cultures[index].SetName(name);
        }

        public void SetCulturePlan(int index, string plan)
        {
            _cultures[index].SetPlan(plan);
        }
    }

}
