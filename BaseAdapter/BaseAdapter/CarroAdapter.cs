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
using Domain;
using Java.Lang;

namespace BaseAdapter
{
    public class CarroAdapter : Android.Widget.BaseAdapter
    {

        public Context context { get; set; }
        private List<Carro> lista;
          
        public CarroAdapter(Activity host, List<Carro> carros)
        {
            context = host;
            lista = carros;
            var a = lista[1];
        }

        public override int Count
        {
            get
            {
                return lista.Count();
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            Carro carro = lista[position];
            
            if(convertView == null)
            {
                LayoutInflater inflater = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
                convertView = inflater.Inflate(Resource.Layout.carros, null);
            }

            TextView modelo = convertView.FindViewById<TextView>(Resource.Id.t1);
            TextView marca = convertView.FindViewById<TextView>(Resource.Id.t2);
            ImageView image = convertView.FindViewById<ImageView>(Resource.Id.image);

            modelo.Text = carro.Modelo;
            marca.Text = carro.Marca;
            image.SetImageResource(carro.Image);
            

            return convertView;
        }
    }
}