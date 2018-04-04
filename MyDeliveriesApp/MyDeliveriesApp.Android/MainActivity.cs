using Android.App;
using Android.Widget;
using Android.OS;

namespace MyDeliveriesApp.Droid
{
    [Activity(Label = "MyDeliveriesApp", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        EditText nameEditText; //same name but not necessary
        Button helloButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            nameEditText = FindViewById<EditText>(Resource.Id.nameEditText);
            helloButton = FindViewById<Button>(Resource.Id.helloButton);

            helloButton.Click += HelloButton_Click;
        }

        private void HelloButton_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, $"Hello {nameEditText.Text}", ToastLength.Long).Show();
        }
    }
}

