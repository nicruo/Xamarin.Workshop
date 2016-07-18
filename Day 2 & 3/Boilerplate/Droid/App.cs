using System;
using Boilerplate.ViewModels;

namespace Boilerplate.Droid
{
    public static class App
    {
        private static ViewModelLocator _locator;
        public static ViewModelLocator Locator
        {
            get
            {
                if (_locator == null)
                {
                    _locator = new ViewModelLocator();
                }
                return _locator;
            }
        }
    }
}