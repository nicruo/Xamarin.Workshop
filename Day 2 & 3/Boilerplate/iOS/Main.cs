using System;
using System.Collections.Generic;
using System.Linq;
using Boilerplate.ViewModels;
using Foundation;
using UIKit;

namespace Boilerplate.iOS
{
    public class Application
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

        static void Main(string[] args)
        {
             UIApplication.Main(args, null, "AppDelegate");
        }
    }
}