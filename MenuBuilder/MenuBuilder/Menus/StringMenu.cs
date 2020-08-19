using MenuBuilder.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Menus
{
    public class StringMenu:IMenu
    {
        private StringBuilder _content;
        public Dictionary<string, Func<string>> Actions { get; set; }


        public StringMenu()
        {
            _content = new StringBuilder();
            Actions = new Dictionary<string, Func<string>>();
        }

        public string Content { get => _content.ToString(); }

        public void AddAction(string key, Func<string> action, string description)
        {
            Actions.Add(key, action);
            _content.AppendLine($"{key} : for {description}");
        }
    }
}
