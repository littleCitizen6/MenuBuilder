using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Abstraction
{
    public interface IMenu
    {
        Dictionary<string, Action> Actions { get; }
        string Content { get; }
        IParamVaidator Validator { get; set; }

        void AddAction(string key, Action action, string describe);
        
    }
}
