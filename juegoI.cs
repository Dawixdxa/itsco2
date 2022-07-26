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
    [Activity(Label = "juegoI", MainLauncher = false)]
    
    public class juegoI : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            SetContentView(Resource.Layout.juegoI);

            var btnN1 = FindViewById<Button>(Resource.Id.btnN1);
            var btnN2 = FindViewById<Button>(Resource.Id.btnN2);
            var btnN3 = FindViewById<Button>(Resource.Id.btnN3);
            var btnN4 = FindViewById<Button>(Resource.Id.btnN4);
            var btnN5 = FindViewById<Button>(Resource.Id.btnN5);

            btnN1.Click += delegate
            {

                Intent itn = new Intent(this, typeof(N1));
                StartActivity(itn);


            };
            btnN2.Click += delegate
            {
                Intent itn = new Intent(this, typeof(N2));
                StartActivity(itn);


            };
            btnN3.Click += delegate
            {
                Intent itn = new Intent(this, typeof(N3));
                StartActivity(itn);
            };
            btnN4.Click += delegate
            {
                Intent itn = new Intent(this, typeof(N4));
                StartActivity(itn);
            };
            btnN5.Click += delegate
            {
                Intent itn = new Intent(this, typeof(N5));
                StartActivity(itn);
            };






            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}