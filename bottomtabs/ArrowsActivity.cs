﻿using Android.App;
using Android.OS;

namespace bottomtabs
{
    [Activity(Label = "ArrowsActivity")]			
    public class ArrowsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ArrowsPage);
        }
    }
}

