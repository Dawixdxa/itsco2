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
    [Activity(Label = "N4")]
    public class N4 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetContentView(Resource.Layout.N4);
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}