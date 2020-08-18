using MenuBuilder.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Providers
{
    public class ConsoleProvider : IParamProvider
    {
        public T Get<T>() where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            return (T)Convert.ChangeType(Console.ReadLine(),typeof(T));
        }
    }
}
