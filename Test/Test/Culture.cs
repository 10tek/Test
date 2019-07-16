using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Culture
    {
        private string _cultureName;
        private string _culturePlan;
        
        public Culture()
        {
        }

        public Culture(string name, string plan)
        {
            Add(name, plan);
        }

        public void Add(string name, string plan)
        {
            _cultureName = name;
            _culturePlan = plan;
        }
        
        
        public string GetName()
        {
            return _cultureName;
        }

        public void SetName(string cultureName)
        {
            _cultureName = cultureName;
        }

        public string GetPlan()
        {
            return _culturePlan;
        }

        public void SetPlan(string culturePlan)
        {
            _culturePlan = culturePlan;
        }

    }
}
