using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.Collections.Generic;

namespace Junan.App
{//Junan.App
    [Activity(Label = "Junan.App", MainLauncher = true)]
    public class MainActivity : Activity
    {
        static readonly List<string> phoneNumbers = new List<string> { "15563718500", "15589776022" };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            //ActionBar.set
            // Set our view from the "main" layout resource
            var tabchecked = ActionBar.NewTab();
            tabchecked.SetText("检查");
            tabchecked.TabSelected += (sender, args) =>
            {
                // Do something when tab is selected
                SetContentView(Resource.Layout.Main);
            };
            var tabRecord = ActionBar.NewTab();
            tabRecord.TabSelected += (sender, args) =>
            {
                SetContentView(Resource.Layout.Index);
            };
            tabRecord.SetText("检查");

            ActionBar.AddTab(tabchecked);
            ActionBar.AddTab(tabRecord);


        }

    }
}

