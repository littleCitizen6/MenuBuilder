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
        public void BootConditions<T>(IMenu menu, T key)
        {
            _conditions.Clear();
            _conditions.Add("is key exist", menu.Actions<T>().Keys.Contains(key));
        }

        public bool IsValid<T>(T parm)
        {
            return !_conditions.ContainsValue(false);
        }
    }
}
