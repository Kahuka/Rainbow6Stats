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
using R6Stats.Core.Models;
using FFImageLoading;

namespace R6Stats.R6Stats
{
    class R6ProfileAdapter : BaseAdapter<ProfilesDetails>
    {
        List<ProfilesDetails> _items;
        Activity _context;

        public R6ProfileAdapter(Activity context, List<ProfilesDetails> items) : base()
        {
            this._context = context;
            this._items = items;
        }


        public override ProfilesDetails this[int position]
        {
            get { return _items[position]; }
        }

        public override int Count
        {
            get { return _items.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;

        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _items[position];
            var imgURL = "https://ubisoft-avatars.akamaized.net/" + item.P_id + "/default_146_146.png";
            var rankImgURL = "https://r6tab.com/images/pngranks/" + item.P_currentrank + ".png";
            View view = convertView;
            if (view == null)
                view = _context.LayoutInflater.Inflate(Resource.Layout.profile_layout, null);

            view.FindViewById<TextView>(Resource.Id.profileName).Text = "Name: " + item.P_name;
            view.FindViewById<TextView>(Resource.Id.profileLevel).Text = "Level: " + item.P_level;
            view.FindViewById<TextView>(Resource.Id.profileKD).Text = "KD: " + item.Kd / 100;
            view.FindViewById<TextView>(Resource.Id.profileMMR).Text = "MMR: " + item.P_currentmmr;
            var imageView = view.FindViewById<ImageView>(Resource.Id.profilePic);
            var rankImageView = view.FindViewById<ImageView>(Resource.Id.mmrPic);

            ImageService.Instance.LoadUrl(imgURL).Into(imageView);
            ImageService.Instance.LoadUrl(rankImgURL).Into(rankImageView);
            return view;
        }
    }
}