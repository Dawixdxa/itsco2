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
    [Activity(Label = "N1")]
    public class N1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetContentView(Resource.Layout.N1);
            base.OnCreate(savedInstanceState);

            var cbx1 = FindViewById<Button>(Resource.Id.cbx1);
            var cbx2 = FindViewById<Button>(Resource.Id.cbx2);
            var cbx3 = FindViewById<Button>(Resource.Id.cbx3);
            var cbx4 = FindViewById<Button>(Resource.Id.cbx4);
            var cbx5 = FindViewById<Button>(Resource.Id.cbx5);
            var cbx6 = FindViewById<Button>(Resource.Id.cbx6);
            var cbx7 = FindViewById<Button>(Resource.Id.cbx7);
            var cbx8 = FindViewById<Button>(Resource.Id.cbx8);
            var cbx9 = FindViewById<Button>(Resource.Id.cbx9);
            var cbx10 = FindViewById<Button>(Resource.Id.cbx10);
            var cbx11 = FindViewById<Button>(Resource.Id.cbx11);
            var cbx12 = FindViewById<Button>(Resource.Id.cbx12);
            var cbx13 = FindViewById<Button>(Resource.Id.cbx13);
            var cbx14= FindViewById<Button>(Resource.Id.cbx14);
            var cbx15= FindViewById<Button>(Resource.Id.cbx15);
            var cbx16= FindViewById<Button>(Resource.Id.cbx16);
            var cbx17= FindViewById<Button>(Resource.Id.cbx17);
            var cbx18= FindViewById<Button>(Resource.Id.cbx18);
            var cbx19= FindViewById<Button>(Resource.Id.cbx19);
            var cbx20= FindViewById<Button>(Resource.Id.cbx20);
            var btnResivar = FindViewById<Button>(Resource.Id.btnRevisar1);
        }
    }
}