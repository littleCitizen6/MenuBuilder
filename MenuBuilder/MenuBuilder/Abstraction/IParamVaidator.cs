using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Abstraction
{
    public interface IParamVaidator
    {
        void BootConditions<T>(IMenu menu, T key);
        bool IsValid<T>(T parm);

    }
}
