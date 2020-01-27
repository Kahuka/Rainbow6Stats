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
using Newtonsoft.Json;
using R6Stats.Core;
using R6Stats.Core.Models;
using R6Stats.R6Stats;

namespace R6Stats.R6Stats
{
    [Activity(Label = "R6Stats")]
    public class R6Stats : Activity
    {
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.stats_layout);

            var profilesDetails = JsonConvert.DeserializeObject<ProfilesDetails>(Intent.GetStringExtra("profilesDetails"));

            var id = profilesDetails.P_id;



            var nameText = FindViewById<TextView>(Resource.Id.nameText);
            var statList = FindViewById<ListView>(Resource.Id.statsList);

            nameText.Text = profilesDetails.P_name;

            string queryString = "https://r6tab.com/api/player.php?p_id=" + id;

            var data = await DataService.R6OverallData(queryString);
            nameText.Text = data.P_data[1].ToString();
            //var data = await DataService.SeasonalData(queryString);
            //statList.Adapter = new SeasonalStatsAdapter(this, data.Seasonal);


        }
    }
}