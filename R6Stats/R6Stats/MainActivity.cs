using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using R6Stats.Core;
using R6Stats;
using static Android.Widget.AdapterView;
using Android.Content;
using Newtonsoft.Json;
using R6Stats.Core.Models;

namespace R6Stats
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var SearchBtn = FindViewById<Button>(Resource.Id.searchButton);
            var UsernameEditText = FindViewById<EditText>(Resource.Id.usernameText);
            var profileView = FindViewById<ListView>(Resource.Id.profileView);
            SearchBtn.Click += async delegate
            {   

                    string username = UsernameEditText.Text;
                    string queryString = "https://r6tab.com/api/search.php?platform=uplay&search=" + username;
                    var data = await DataService.GetR6Profiles(queryString);
                    profileView.Adapter = new R6Stats.R6ProfileAdapter(this, data.Results);

                profileView.ItemClick += (object sender, ItemClickEventArgs e) =>
                {
                    var profilesDetails = data.Results[e.Position];

                    var intent = new Intent(this, typeof(R6Stats.R6Stats));
                    intent.PutExtra("profilesDetails", JsonConvert.SerializeObject(profilesDetails));
                    StartActivity(intent);
                };



            };

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}