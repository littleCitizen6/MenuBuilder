using MenuBuilder.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Menus
{
    public class NumbersMenu : IMenu
    {
        private StringBuilder _content;
        public NumbersMenu()
        {
            _content = new StringBuilder();
        }
        
        public string Content {get => _content.ToString();}

        public Dictionary<string, Action> Actions()
        {
            throw new NotImplementedException();
        }

        public void AddAction(string key, Action action, string description)
        {
            Actions().Add(key, action);
            _content.AppendLine($"{key} : for {description}");
        }
    }
}
