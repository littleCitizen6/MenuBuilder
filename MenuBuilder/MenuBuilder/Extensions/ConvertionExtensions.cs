using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Extensions
{
    public static class ConvertionExtensions
    {
        public static bool TryParse<T>(this object obj, out T requestedFormat)
        {
            try
            {
                requestedFormat = (T)Convert.ChangeType(obj, typeof(T));
                return true;
            } 
            catch (Exception)
            {
                requestedFormat = default;
                return false;
            }
        }
    }
}
