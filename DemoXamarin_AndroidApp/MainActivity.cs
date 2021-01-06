using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace DemoXamarin_AndroidApp
{
	[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
	public class MainActivity : AppCompatActivity
	{
		EditText textA, textB;
		Button button;
		TextView textResult;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			Xamarin.Essentials.Platform.Init(this, savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_main);

			// New code will go here
			textA = FindViewById<EditText>(Resource.Id.editTextA);
			textB = FindViewById<EditText>(Resource.Id.editTextB);
			button = FindViewById<Button>(Resource.Id.buttonNhap);
			textResult = FindViewById<TextView>(Resource.Id.textViewResult);

			button.Click += btn_Click;
		}

		private void btn_Click(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textA.Text) || string.IsNullOrWhiteSpace(textB.Text))
			{
				textResult.Text = "Missing required field";
			}
			else
			{
				textResult.Text = $"Value 1: {textA.Text}, value 2: {textB.Text}";
			}
		}

		public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
		{
			Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

			base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
		}
	}
}