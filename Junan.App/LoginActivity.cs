using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Junan.App
{
    [Activity(Label = "Login")]
    public class LoginActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Login);

            Button loginButton = FindViewById<Button>(Resource.Id.Login);
            loginButton.Click += Logion;
        }

        private void Logion(object sender, EventArgs e)
        {
            Console.WriteLine("Logion Button"); ;
        }
    }
}