using MenuBuilder.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Menus
{
    public class NumbersMenu : IMenu
    {
        private StringBuilder _content;
        public Dictionary<string, Action> Actions { get; set; }
        public Type KeyType { get ; set ; }
        public IParamVaidator Validator { get ; set; }


        public NumbersMenu(Type keyType)
        {
            _content = new StringBuilder();
            KeyType = keyType;
            Validator.BootConditions<keyType>();
        }
        
        public string Content {get => _content.ToString();}

        public void AddAction(string key, Action action, string description)
        {
            Actions.Add(key, action);
            _content.AppendLine($"{key} : for {description}");
        }
    }
}
