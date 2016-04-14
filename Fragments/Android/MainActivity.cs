using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Fragments;
using Android.Util;
using Android.Support.V7.App;
using Android.Support.V4.Widget;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using SupportFragment = Android.Support.V4.App.Fragment;

namespace Android
{
    [Activity(Label = "FragmentLearning", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/MyTheme")]
    public class MainActivity : ActionBarActivity
    {

        private Toolbar mToolbar;
        private DrawerLayout mDrawerLayout;
        private MyActionBarDrawerToggle mDrawerToggle;
        private FrameLayout mLeftDrawer;
        private FragmentManager mFragmentManager;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            // Criando o Toolbar
                mToolbar = FindViewById<Toolbar> (Resource.Id.toolbar);
                SetSupportActionBar(mToolbar);
                SupportActionBar.Title = "Test the toolbar";
            Log.Info("LOG", "Toolbar criado com sucesso!");

            // Criando o Fragment
                mFragmentManager = new FragmentManager(this);
                mFragmentManager.IniciarFragments();


            Log.Info("LOG", "Fragment criado com sucesso!");

            // Criando Drawer Layout e MyActionBarDrawerToggle
                mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
                mLeftDrawer = FindViewById<FrameLayout>(Resource.Id.left_drawer);

                var mFragmentTrans = SupportFragmentManager.BeginTransaction();
                mFragmentTrans.Add(Resource.Id.left_drawer, new LeftDrawerFragment());
                mFragmentTrans.Commit();

                mDrawerToggle = new MyActionBarDrawerToggle(
                    this,
                    mDrawerLayout,
                    mToolbar,
                    Resource.String.openDrawer,
                    Resource.String.closeDrawer);

                mDrawerLayout.SetDrawerListener(mDrawerToggle);
                SupportActionBar.SetHomeButtonEnabled(true);
                SupportActionBar.SetDisplayShowTitleEnabled(true);
                mDrawerToggle.SyncState();
            Log.Info("LOG", "Drawer Layout criado com sucesso!");
            
            // Verificar o estado do Bundle
            if (bundle != null)
                {
                    Log.Info("LOG", "Estado do Drawer Layout: " + bundle.GetString("DrawerState"));

                    if (bundle.GetString("DrawerState").Equals("Opened"))
                    {
                        mToolbar.SetTitle(Resource.String.openDrawer);
                    }else
                    {
                        mToolbar.SetTitle(Resource.String.closeDrawer);
                    }
                }else
                {
                    Log.Info("LOG", "Primeira vez da activity.");
                    mToolbar.SetTitle(Resource.String.closeDrawer);
                }
                
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.action_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            mDrawerToggle.OnOptionsItemSelected(item);

            switch (item.ItemId)
            {
                case Android.Resource.Id.action_fragment1:
                    Log.Info("LOG", "OnOptionsItemSelected() : action_frame1");
                    mFragmentManager.SwapFragment("Fragment1");

                    return true;

                case Android.Resource.Id.action_fragment2:
                    Log.Info("LOG", "OnOptionsItemSelected() : action_frame2");
                    mFragmentManager.SwapFragment("Fragment2");

                    return true;

                case Android.Resource.Id.action_fragment3:
                    Log.Info("LOG", "OnOptionsItemSelected() : action_frame3");
                    mFragmentManager.SwapFragment("Fragment3");

                    return true;

                default:
                    return base.OnOptionsItemSelected(item);
            }
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            if (mDrawerLayout.IsDrawerOpen((int)GravityFlags.Left))
            {
                outState.PutString("DrawerState", "Opened");
            }
            else
            {
                outState.PutString("DrawerState", "Closed");
            }
            base.OnSaveInstanceState(outState);
        }
        
    }
}

