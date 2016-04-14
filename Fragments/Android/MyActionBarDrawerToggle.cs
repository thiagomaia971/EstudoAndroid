using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using ActionBarDrawerToggle = Android.Support.V7.App.ActionBarDrawerToggle;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace Android
{
    public class MyActionBarDrawerToggle : ActionBarDrawerToggle
    {

        private ActionBarActivity mHostActivity;
        private int mOpenedResource;
        private int mClosedResource;

        public MyActionBarDrawerToggle(ActionBarActivity host, DrawerLayout drawerLayout, Toolbar toolbar, int openedResource, int closedResource) 
            : base(host, drawerLayout, toolbar, openedResource, closedResource)
        {
            mHostActivity = host;
            mOpenedResource = openedResource;
            mClosedResource = closedResource;
        }

        public override void OnDrawerOpened(View drawerView)
        {
            mHostActivity.SupportActionBar.SetTitle(mOpenedResource);
            base.OnDrawerOpened(drawerView);
        }

        public override void OnDrawerClosed(View drawerView)
        {
            mHostActivity.SupportActionBar.SetTitle(mClosedResource);
            base.OnDrawerClosed(drawerView);
        }

        public override void OnDrawerSlide(View drawerView, float slideOffset)
        {
            base.OnDrawerSlide(drawerView, slideOffset);
        }
    }
}