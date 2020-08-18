using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Abstraction
{
    public interface IMenu
    {
        Dictionary<T, Action> Actions<T>();
        string Content { get;  set; }
    }
}
