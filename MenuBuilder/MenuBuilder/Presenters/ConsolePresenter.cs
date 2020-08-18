using MenuBuilder.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Presenters
{
    public class ConsolePresenter : IPresenter
    {
        public void Display(string message)
        {
            Console.WriteLine(message);
        }

        public void DisplayOnly(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
        }
    }
}
