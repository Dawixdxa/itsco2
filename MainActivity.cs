﻿using Android.App;
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
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource

            SetContentView(Resource.Layout.activity_main);

            var btnInfo = FindViewById<Button>(Resource.Id.btnInfo);
            var btnjuego = FindViewById<Button>(Resource.Id.btnJuego);

            btnInfo.Click += delegate
            {
                Intent itn = new Intent(this, typeof(Info));
                StartActivity(itn);


            };
            btnjuego.Click += delegate
            {
                Intent itn = new Intent(this, typeof(juegoI));
                StartActivity(itn);


            };




        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}