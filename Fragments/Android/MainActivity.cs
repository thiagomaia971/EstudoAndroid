using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;
using Android.Support.V4.Widget;
using Android.OS;
using Android.Fragments;
using Android.Util;

namespace Android
{
    [Activity(Label = "FragmentLearning", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/MyTheme")]
    public class MainActivity : ActionBarActivity
    {

        private Android.Support.V7.Widget.Toolbar mToolbar;
        FragmentTransaction mFragmentManager;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            // Criando o actionBar
                mToolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
                SetSupportActionBar(mToolbar);
                SupportActionBar.Title = "Test the toolbar";

            // Criando o Fragment
                mFragmentManager = FragmentManager.BeginTransaction();
                mFragmentManager.Add(Resource.Id.fragmentContainer, new Fragment1(), "Fragment1");
                mFragmentManager.Commit();
            
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.action_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.action_fragment1:
                    Log.Info("LOG", "OnOptionsItemSelected() : action_frame1");
                    swapFragment(new Fragment1());

                    return true;

                case Android.Resource.Id.action_fragment2:
                    Log.Info("LOG", "OnOptionsItemSelected() : action_frame2");
                    swapFragment(new Fragment2());

                    return true;

                case Android.Resource.Id.action_fragment3:
                    Log.Info("LOG", "OnOptionsItemSelected() : action_frame3");
                    swapFragment(new Fragment3());

                    return true;

                default:
                    return base.OnOptionsItemSelected(item);
            }
            return base.OnOptionsItemSelected(item);
        }

        private void swapFragment(Fragment fragment)
        {
            mFragmentManager.Remove(new Fragment1());
            mFragmentManager.Add(Resource.Id.fragmentContainer, fragment, "Fragment2");
            Log.Info("LOG", "swapFragment()");
        }

    }
}

