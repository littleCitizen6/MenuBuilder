﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Abstraction
{
    public interface IMenu
    {
        Dictionary<string, Func<string,string>> Actions { get; }
        string Content { get; }
        void AddAction(string key, Func<string,string> func, string describe);
        
    }
}
