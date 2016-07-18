using System;
using Android.Widget;

namespace Boilerplate.Droid.Activities
{
    public partial class HomeActivity
    {
        private ListView _listView;
        public ListView ListView
        {
            get
            {
                if (_listView == null)
                {
                    _listView = FindViewById<ListView>(Resource.Id.listView);
                }

                return _listView;
            }
        }
    }
}

