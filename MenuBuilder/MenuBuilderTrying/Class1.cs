using System;
using System.Collections.Generic;
using System.Text;
using MenuBuilder;
using MenuBuilder.Abstraction;
using MenuBuilder.Browsers;
using MenuBuilder.Menus;
using MenuBuilder.Presenters;
using MenuBuilder.Providers;
using MenuBuilder.Validators;


namespace MenuBuilderTrying
{
    public class Class1
    {
        private IBrowser _browser;
        private IParamProvider _provider;
        private IPresenter _presenter;
        private IParamVaidator _validator;
        public MenuRunner<string> Runner { get; set; }

        public Class1()
        {
            var headMenu = new StringMenu();
            headMenu.AddAction("void1", Action1, "for say hi");
            headMenu.AddAction("m2", MoveToMenu2, "for move to menu 2");
            headMenu.AddAction("exit", Exit, "for exit");
            var menu2 = new NumbersMenu();
            menu2.AddAction("1", Action1, "for say hi");
            menu2.AddAction("2", Exit, "for exit");
            menu2.AddAction("3", Previous, "for the previous menu");
            _browser = new StackBrowser(headMenu);
            _provider = new ConsoleProvider();
            _presenter = new ConsolePresenter();
            _validator = new StringParamValidator();
            Runner = new MenuRunner<string>(_presenter, _provider, _validator, _browser);
            Runner.AddMenu("m1", headMenu);
            Runner.AddMenu("m2", menu2);
        }
        public string Action1(string key)
        {
            _presenter.WaitForKeyDisplay("hello fucker");
            return "succeded";
        }
        public string Previous(string key)
        {
            if(_browser.PreviousOrDefult()==null)
            {
                _presenter.WaitForKeyDisplay("there is no previous menu, press key to continue");
            }
            return "succeded";
        }

        public string Exit(string key)
        {
            Runner.Exit();
            return "succeded";
        }

        public string MoveToMenu2(string key)
        {
            Runner.Browser.Current = Runner.Menus["m2"];
            return "succeded";
        }
    }
}
