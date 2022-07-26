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
    
    [Activity(Label = "Info", MainLauncher = false)]
    public class Info : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {


            SetContentView(Resource.Layout.Info);

            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}