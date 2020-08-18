using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Abstraction
{
    public interface IParamVaidator
    {
        void BootConditions(IMenu menu);
    }
}
