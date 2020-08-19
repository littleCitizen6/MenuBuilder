﻿using MenuBuilder.Abstraction;
using MenuBuilder.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Menus
{
    public class NumbersMenu : IMenu
    {
        private StringBuilder _content;
        public Dictionary<string, Action> Actions { get; set; }


        public NumbersMenu()
        {
            _content = new StringBuilder();
            Actions = new Dictionary<string, Action>();
        }
        
        public string Content {get => _content.ToString();}

        public void AddAction(string key, Action action, string description)
        {
            if(!key.TryParse<int>(out int a))
            {
                throw new ArgumentException("key need to be number in format string...");
            }
            Actions.Add(key, action);
            _content.AppendLine($"{key} : for {description}");
        }
    }
}
