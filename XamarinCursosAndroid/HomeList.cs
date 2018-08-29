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

namespace XamarinCursosAndroid
{
    class HomeList : BaseAdapter<TableItem>
    {
        public HomeList( Activity context, List<TableItem> items) : base()
        {
            this.context = context;
            this.items = items;
        }

        List<TableItem> items;
        Activity context;

        public override TableItem this[int position]
        {
            get { return items[position]; }
        }

        public override int Count
        {
            get { return items.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            var view = convertView;

            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.Cell, null);

            view.FindViewById<TextView>(Resource.Id.textView1).Text = item.Titulo;
            view.FindViewById<TextView>(Resource.Id.textView2).Text = item.Descripcion;
            view.FindViewById<ImageView>(Resource.Id.imageView1).SetImageResource(item.ImageId);

            return view;

        }
    }
}