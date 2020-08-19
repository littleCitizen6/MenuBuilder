using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Menus
{
    public class StringMenu
    {
        private StringBuilder _content;
        public Dictionary<string, Action> Actions { get; set; }


        public StringMenu()
        {
            _content = new StringBuilder();
        }

        public string Content { get => _content.ToString(); }

        public void AddAction(string key, Action action, string description)
        {
            Actions.Add(key, action);
            _content.AppendLine($"{key} : for {description}");
        }
    }
}
