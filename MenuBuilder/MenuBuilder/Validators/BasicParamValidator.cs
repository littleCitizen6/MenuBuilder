using MenuBuilder.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder.Validators
{
    public class BasicParamValidator : IParamVaidator
    {
        private Dictionary<string, bool> _conditions;
        public BasicParamValidator()
        {
            _conditions = new Dictionary<string, bool>();
        }
        public void BootConditions(IMenu menu, string key)
        {
            _conditions.Clear();
            _conditions.Add("is key exist", menu.Actions().Keys.Contains(key));
        }

        public bool IsValid(string parm)
        {
            return !_conditions.ContainsValue(false);
        }
    }
}
