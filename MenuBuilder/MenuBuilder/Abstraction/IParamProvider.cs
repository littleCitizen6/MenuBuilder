using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Abstraction
{
    public interface IParamProvider
    {
        T Get<T>() where T :  IComparable, IConvertible, IComparable<T>, IEquatable<T>;
    }
}
