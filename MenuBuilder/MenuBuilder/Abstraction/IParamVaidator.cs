using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Abstraction
{
    public interface IParamVaidator
    {
        void BootConditions( string key, IMenu menu);
        bool IsValid(string parm, IMenu menu);

    }
}
