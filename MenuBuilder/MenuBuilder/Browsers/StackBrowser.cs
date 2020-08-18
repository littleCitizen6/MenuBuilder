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

        IMenu IBrowser.CurrentOrDefault { 
            get => _current; 
            set 
            {
                if (_current != null) 
                {
                    _history.Push(_current);
                }
                this._current = value;
            }
        }

        public StackBrowser()
        {
            _history = new Stack<IMenu>();
        }

        public IMenu PreviousOrDefult()
        {
            _current = _history.Pop();
            return _current;
        }

    }
}
