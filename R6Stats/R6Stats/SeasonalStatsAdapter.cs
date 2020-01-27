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

namespace R6Stats.R6Stats
{
    class SeasonalStatsAdapter : BaseAdapter<Seasonal>
    {
        List<Seasonal> _items;
        Activity _context;

        public SeasonalStatsAdapter(Activity context, List<Seasonal> items) : base()
        {
            this._context = context;
            this._items = items;
        }


        public override Seasonal this[int position]
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
            View view = convertView;
            if (view == null)
                view = _context.LayoutInflater.Inflate(Resource.Layout.stats_layout, null);

            view.FindViewById<TextView>(Resource.Id.currentmmr).Text = "Current mmr" + item.Current_EU_mmr;
            view.FindViewById<TextView>(Resource.Id.lastmmr).Text = "Last mmr" + item.Last_EU_mmr;
            view.FindViewById<TextView>(Resource.Id.casualwins).Text = "Casual wins" + item.Total_casualwins;
            view.FindViewById<TextView>(Resource.Id.casuallosses).Text = "Casual losses" + item.Total_casuallosses;
            view.FindViewById<TextView>(Resource.Id.casualtotal).Text = "Total casual games" + item.Total_casualtotal;
            view.FindViewById<TextView>(Resource.Id.rankedwins).Text = "Ranked wins" + item.Total_rankedwins;
            view.FindViewById<TextView>(Resource.Id.rankedlosses).Text = "Ranked losses" + item.Total_rankedlosses;
            view.FindViewById<TextView>(Resource.Id.rankedtotal).Text = "Total ranked games" + item.Total_rankedtotal;
            view.FindViewById<TextView>(Resource.Id.casualkils).Text = "Casual kills" + item.Total_casualkills;
            view.FindViewById<TextView>(Resource.Id.casualdeaths).Text = "Casual Deaths" + item.Total_casuallosses;
            view.FindViewById<TextView>(Resource.Id.rankedkils).Text = "Ranked kills" + item.Total_rankedkills;
            view.FindViewById<TextView>(Resource.Id.rankeddeaths).Text = "Ranked deaths" + item.Total_rankeddeaths;
            return view;
        }
    }
}