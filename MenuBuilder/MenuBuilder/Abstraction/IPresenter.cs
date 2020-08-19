using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Abstraction
{
    public interface IPresenter
    {
        void Display(string message);
        void DisplayOnly(string message);
        void WaitForKeyDisplay(string message);
    }
}
