using MenuBuilder.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuBuilder
{
    public class MenuRunner<TKey>
    {
        public Dictionary<TKey, IMenu> Menus { get; set; }
        public IPresenter Presenter { get; set; }
        public IParamProvider Provider { get; set; }
        public IParamVaidator ParamVaidator { get; set; }
        public IBrowser Browser { get; set; }
        public MenuRunner(IPresenter presenter, IParamProvider provider, IParamVaidator validator, IBrowser browser)
        {
            Menus = new Dictionary<TKey, IMenu>();
            Presenter = presenter;
            Provider = provider;
            ParamVaidator = validator;
            Browser = browser;
        }

        public bool AddMenu(TKey indexKey,IMenu menu)
        {
            return Menus.TryAdd(indexKey, menu);
            
        }

        public void Run()
        {
            do
            {
                Presenter.DisplayOnly(Browser.Current.Content);
                string choice = Provider.Get<string>();
                if (ParamVaidator.IsValid(choice, Browser.Current))
                {
                    Browser.Current.Actions[choice](choice);
                }
                else
                {
                    Presenter.WaitForKeyDisplay("invalid param, please insert correct option, press key to continue");
                }
            } while (Browser.Continue);
        }

        public void Exit()
        {
            Browser.Continue = false;
        }
    }
}
