using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Abstraction
{
    public interface IBrowser
    {
        IMenu PreviousOrDefult();
        IMenu CurrentOrDefault { get; set; }
    }
}
