using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace itsco2
{
    [Activity(Label = "N2")]
    public class N2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetContentView(Resource.Layout.N2);
            base.OnCreate(savedInstanceState);
            // Create your application here
        }
    }
}