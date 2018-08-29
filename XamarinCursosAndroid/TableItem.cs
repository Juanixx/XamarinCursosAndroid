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
    class TableItem
    {
        string titulo;
        string descripcion;
        int imageId;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int ImageId { get => imageId; set => imageId = value; }

    }
}