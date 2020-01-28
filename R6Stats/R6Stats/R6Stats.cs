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
using FFImageLoading;
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

            var imgURL = "https://ubisoft-avatars.akamaized.net/" + profilesDetails.P_id + "/default_146_146.png";

            var nameText = FindViewById<TextView>(Resource.Id.nameText);
            var profilePic = FindViewById<ImageView>(Resource.Id.profilePic2);

            var statBoard1 = FindViewById<TextView>(Resource.Id.statboard1);
            var statBoard2 = FindViewById<TextView>(Resource.Id.statboard2);
            var statBoard3 = FindViewById<TextView>(Resource.Id.statboard3);
            var statBoard4 = FindViewById<TextView>(Resource.Id.statboard4);
            var statBoard5 = FindViewById<TextView>(Resource.Id.statboard5);
            var statBoard6 = FindViewById<TextView>(Resource.Id.statboard6);
            var statBoard7 = FindViewById<TextView>(Resource.Id.statboard7);
            var statBoard8 = FindViewById<TextView>(Resource.Id.statboard8);
            var statBoard9 = FindViewById<TextView>(Resource.Id.statboard9);

            nameText.Text = profilesDetails.P_name;
            ImageService.Instance.LoadUrl(imgURL).Into(profilePic);


            string queryString = "https://r6tab.com/api/player.php?p_id=" + id;
            var data = await DataService.R6OverallData(queryString);


            statBoard1.Text = "Total playtime: " + (((data.Data[0] + data.Data[5]) / 60)/60) + " hours";
            statBoard2.Text = "Total kills: " + (data.Data[1] + data.Data[6]);
            statBoard3.Text = "Total Deaths: " + (data.Data[2] + data.Data[7]);
            statBoard4.Text = "Total Wins: " + (data.Data[3] + data.Data[8]);
            statBoard5.Text = "Total Losses: " + (data.Data[4] + data.Data[9]);
            statBoard6.Text = "Melee kills: " + data.Data[18];
            statBoard7.Text = "Headshots: " + data.Data[17];
            statBoard8.Text = "Bullets fires: " + data.Data[16];
            statBoard9.Text = "Max MMR: " + data.Data[29];




        }
    }
}