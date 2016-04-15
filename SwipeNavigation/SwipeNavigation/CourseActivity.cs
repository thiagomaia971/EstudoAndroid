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
using Android.Support.V4.App;
using Domain;
using Android.Support.V4.View;

namespace SwipeNavigation
{
    //[Activity(Label = "SwipeNavigation", MainLauncher = true, Icon = "@drawable/icon")]
    public class CourseActivity : FragmentActivity
    {
        private CourseManager mCourseManager;
        private CoursePagerAdapter mCoursePagerAdapter;
        private ViewPager mViewPager;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CourseActivity);

            mCourseManager = new CourseManager();
            mCourseManager.MoveFirst();

            mCoursePagerAdapter = new CoursePagerAdapter(SupportFragmentManager, mCourseManager);

            mViewPager = FindViewById<ViewPager>(Resource.Id.coursePager);
            mViewPager.Adapter = mCoursePagerAdapter;

        }
    }
}