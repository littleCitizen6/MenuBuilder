using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Abstraction
{
    public interface IMenu
    {
        Dictionary<string, Action> Actions { get; set; }
        string Content { get;  set; }
    }
}
