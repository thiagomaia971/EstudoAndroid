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
using Android.Fragments;
using Android.Support.V7.App;
using SupportFragment = Android.Support.V4.App.Fragment;
using SupportManager = Android.Support.V4.App.FragmentTransaction;

namespace Android
{
    public class FragmentManager
    {
        public SupportFragment CurrentFragment { get; private set; }
        private Fragment1 Fragment1;
        private Fragment2 Fragment2;
        private Fragment3 Fragment3;
        private AppCompatActivity mHost;
        private SupportManager mFragmentTrans;

        public FragmentManager(AppCompatActivity host)
        {
            Fragment1 = new Fragment1();
            Fragment2 = new Fragment2();
            Fragment3 = new Fragment3();
            mHost = host;

            mFragmentTrans = mHost.SupportFragmentManager.BeginTransaction();
            CurrentFragment = Fragment1;
        }

        public void IniciarFragments()
        {
            mFragmentTrans.Add(Resource.Id.fragmentContainer, Fragment1, "Fragment1");

            mFragmentTrans.Add(Resource.Id.fragmentContainer, Fragment2, "Fragment2");
            mFragmentTrans.Hide(Fragment2);

            mFragmentTrans.Add(Resource.Id.fragmentContainer, Fragment3, "Fragment3");
            mFragmentTrans.Hide(Fragment3);

            mFragmentTrans.Commit();
        }

        public void SwapFragment(string fragment)
        {
            mFragmentTrans = mHost.SupportFragmentManager.BeginTransaction();
            mFragmentTrans.SetCustomAnimations(Resource.Animation.slide_in, Resource.Animation.slide_out, Resource.Animation.slide_in, Resource.Animation.slide_out);

            mFragmentTrans.Hide(CurrentFragment);

            switch (fragment)
            {
                case "Fragment1":
                    mFragmentTrans.Show(Fragment1);
                    CurrentFragment = Fragment1;
                    break;

                case "Fragment2":
                    mFragmentTrans.Show(Fragment2);
                    CurrentFragment = Fragment2;
                    break;

                case "Fragment3":
                    mFragmentTrans.Show(Fragment3);
                    CurrentFragment = Fragment3;
                    break;
            }

            mFragmentTrans.AddToBackStack(null);
            mFragmentTrans.Commit();
        }
    }
}