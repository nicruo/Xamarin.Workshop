using System;
using Android.Widget;

namespace Boilerplate.Droid.Activities
{
    public partial class HomeActivity
    {
        private TextView _welcomeTextView;
        public TextView WelcomeTextView
        {
            get
            {
                if (_welcomeTextView == null)
                {
                    _welcomeTextView = FindViewById<TextView>(Resource.Id.welcomeTextView);
                }

                return _welcomeTextView;
            }
        }
    }
}

