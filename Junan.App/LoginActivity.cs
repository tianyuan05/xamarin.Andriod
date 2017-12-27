using System;
using Android.App;
using Android.Content;
using Android.OS;
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

            //var view= new AdapterView(this,Android.Resource.Layout.);

            //var list = new ArrayAdapter("",);
            var phoneNumbers = Intent.Extras.GetStringArrayList("phone_numbers") ?? new string[0];
            this.ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, phoneNumbers);

        }

        private void Logion(object sender, EventArgs e)
        {
            Console.WriteLine("Logion Button"); ;
        }
    }
}