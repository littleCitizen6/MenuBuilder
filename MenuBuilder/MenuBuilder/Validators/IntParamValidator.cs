using MenuBuilder.Abstraction;
using MenuBuilder.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MenuBuilder.Validators
{
    public class IntParamValidator : IParamVaidator
    {
        private Dictionary<string, bool> _conditions;
        public IntParamValidator()
        {
            _conditions = new Dictionary<string, bool>();
        }
        public void BootConditions(string key, IMenu menu)
        {
            _conditions.Clear();
            _conditions.Add("is int", key.TryParse<int>(out int a));
            _conditions.Add("is key exist", menu.Actions.Keys.Contains(key));
        }
        public bool IsValid(string parm, IMenu menu)
        {
            BootConditions(parm, menu);
            return !_conditions.ContainsValue(false);
        }
    }
}
