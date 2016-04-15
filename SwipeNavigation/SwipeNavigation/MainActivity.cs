using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace SwipeNavigation
{
    [Activity(Label = "SwipeNavigation", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        /*CourseManager courseManager;
        CoursePagerAdapter coursePagerAdapter;
        ViewPager viewPager;*/

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            /*courseManager = new CourseManager();
            courseManager.MoveFirst();

            coursePagerAdapter =
                new CoursePagerAdapter(SupportFragmentManager, courseManager);

            viewPager = FindViewById<ViewPager>(Resource.Id.coursePager);
            viewPager.Adapter = coursePagerAdapter;*/
        }
    }
}

