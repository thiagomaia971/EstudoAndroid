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
using SupportFragment = Android.Support.V4.App.Fragment;
using SupportFragmentManager = Android.Support.V4.App.FragmentManager;
using Domain;
using SwipeNavigation.Fragments;
using Android.Util;

namespace SwipeNavigation
{
    public class CoursePagerAdapter : Android.Support.V4.App.FragmentStatePagerAdapter
    {
        private CourseManager courseManager;

        public CoursePagerAdapter(SupportFragmentManager fm, CourseManager courseManager)
            : base (fm)
        {
            this.courseManager = courseManager;
        }

        public override SupportFragment GetItem(int position)
        {
            Log.Info("LOG", "CoursePagerAdapter.GetItem(" + position + ")");
            //courseManager.MoveTo(position);

            CourseFragment courseFragment = new CourseFragment();
            courseFragment.Courses = courseManager.currentCourses();

            return courseFragment;
        }

        public override int Count
        {
            get { return (int) Math.Ceiling(courseManager.Length/4.0); }
        }
    }
}