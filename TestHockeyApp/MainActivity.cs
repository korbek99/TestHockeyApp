using Android.App;
using Android.Widget;
using Android.OS;
using HockeyApp.Android;
using System;

namespace TestHockeyApp
{
    [Activity(Label = "TestHockeyApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            CrashManager.Register(this, "1662454962bf4523b0664e3adbfaa658");

            Button button = FindViewById<Button>(Resource.Id.myButton);
            button.Click += SendTestHockeyApp;
        }

        private void SendTestHockeyApp(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            CrashManager.Register(this, "1662454962bf4523b0664e3adbfaa658");
            throw new Exception("Se cayo la Aplicacion");
        }
    }
}

