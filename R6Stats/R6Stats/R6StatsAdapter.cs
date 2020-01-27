//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using R6Stats.Core.Models;

//namespace R6Stats.R6Stats
//{
//    class R6StatsAdapter : BaseAdapter<OverallData>
//    {
//        List<ProfilesDetails> _items;
//        Activity _context;

//        public R6StatsAdapter(Activity context, List<OverallData> items) : base()
//        {
//            this._context = context;
//            this._items = items;
//        }


//        public override ProfilesDetails this[int position]
//        {
//            get { return _items[position]; }
//        }

//        public override int Count
//        {
//            get { return _items.Count; }
//        }

//        public override long GetItemId(int position)
//        {
//            return position;

//        }

//        public override View GetView(int position, View convertView, ViewGroup parent)
//        {
//            return View;
//        }
//    }
//}