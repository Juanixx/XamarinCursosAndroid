using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using Android.Content;
using Newtonsoft.Json;

namespace XamarinCursosAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        List<TableItem> tableItems = new List<TableItem>();
        ListView listView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Home);

            listView = FindViewById<ListView>(Resource.Id.listView);
            tableItems.Add(
                new TableItem()
                {
                    Titulo = "Mis nuevos cursos en HTML 5",
                    Descripcion = "Más de mil cursos para usted",
                    ImageId = Resource.Drawable.html5
                });
            tableItems.Add(
                new TableItem()
                {
                    Titulo = "Javascript",
                    Descripcion = "Crea sitios modernos usando JS",
                    ImageId = Resource.Drawable.javascript
                });
            tableItems.Add(
                new TableItem(){
                Titulo = "Aplicaciones IOS",
                Descripcion = "Ingresa al mundo de desarrollo IOS",
                ImageId = Resource.Drawable.ios
            });

            listView.Adapter = new HomeList(this, tableItems);

            listView.ItemClick += ListView_ItemClick;
        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var tmp = tableItems[e.Position];

            var intent = new Intent(this, typeof(ActivityCourse));
            intent.PutExtra("data", JsonConvert.SerializeObject(tmp));
            StartActivity(intent);
        }
    }
}