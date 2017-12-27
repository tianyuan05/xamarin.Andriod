using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Junan.App
{//Junan.App
    [Activity(Label = "Junan.App", MainLauncher = true)]
    public class MainActivity : Activity
    {
        TextView textView ;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            btnLogin.Click += OnLogin;
            textView = FindViewById<TextView>(Resource.Id.txtUserName);

        }

        private void OnLogin(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(LoginActivity));
            //intent.PutStringArrayListExtra("LoginActivity", phoneNumbers);
            StartActivity(intent);
        }
    }
}

