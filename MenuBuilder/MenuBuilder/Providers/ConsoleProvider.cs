using MenuBuilder.Abstraction;
using MenuBuilder.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Providers
{
    public class ConsoleProvider : IParamProvider
    {
        public T Get<T>() where T : IComparable, IConvertible, IComparable<T>, IEquatable<T>
        {
            T requstedFormat;
            var toParse = Console.ReadLine();
            if (!toParse.TryParse<T>(out requstedFormat))
            {
                throw new FormatException("input is not in the requested type");
            }
            return requstedFormat;

        }
    }
}
