using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Domain;

namespace BaseAdapter
{
    [Activity(Label = "BaseAdapter", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        private List<Carro> carros = new List<Carro>();
        private ListView mListView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            carros.Add(new Carro("Modelo1", "Carro1", Resource.Drawable.carro1));
            carros.Add(new Carro("Modelo2", "Carro2", Resource.Drawable.carro2));
            carros.Add(new Carro("Modelo3", "Carro3", Resource.Drawable.carro3));
            carros.Add(new Carro("Modelo4", "Carro4", Resource.Drawable.carro4));

            mListView = FindViewById<ListView>(Resource.Id.lv);
            mListView.Adapter = new CarroAdapter(this, carros);

        }
    }
}

