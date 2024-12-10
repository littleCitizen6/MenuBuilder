using MenuBuilder.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder.Browsers
{
    public class StackBrowser : IBrowser
    {
        private Stack<IMenu> _history;
        private IMenu _current = null;

        IMenu IBrowser.Current { 
            get => _current; 
            set 
            {
                _history.Push(_current);
                this._current = value;
            }
        }

        public bool Continue { get ; set ; }

        public StackBrowser(IMenu menu)
        {
            _history = new Stack<IMenu>();
            Continue = true;
            _current = menu;
        }

        public StackBrowser()
        {
            _history = new Stack<IMenu>();
            Continue = true;
        }

        public IMenu PreviousOrDefult()
        {
            _current = _history.Pop();
            return _current;
        }

    }
}
