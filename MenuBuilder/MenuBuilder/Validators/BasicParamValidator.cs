using MenuBuilder.Abstraction;
using MenuBuilder.Extensions;
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
        public void BootConditions<T>(string key, IMenu menu)
        {
            _conditions.Clear();
            _conditions.Add("is in format", key.TryParse<T>(out T t));
            _conditions.Add("is key exist", menu.Actions.Keys.Contains(key));
        }

        public bool IsValid(string parm, IMenu menu)
        {
            BootConditions(parm, menu);
            return !_conditions.ContainsValue(false);
        }
    }
}
