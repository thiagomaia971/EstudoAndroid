using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Domain;
using SupportFragment = Android.Support.V4.App.Fragment;

namespace SwipeNavigation.Fragments
{
    public class CourseFragment : SupportFragment
    {

        private TextView mTitle;
        private TextView mDescription;
        private ImageView mImageCourse;

        public Course Course { get; set; }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.CourseFragment, container, false);

            // Init the components

                mTitle = view.FindViewById<TextView>(Resource.Id.textTitle);
                mDescription = view.FindViewById<TextView>(Resource.Id.textDescription);
                mImageCourse = view.FindViewById<ImageView>(Resource.Id.imageCourse);

                mTitle.Text = Course.Title;
                mDescription.Text = Course.Description;
                mImageCourse.SetImageResource(ResourceHelper.TranslateDrawableWithReflection(Course.Image));

            return view;
        }
    }
}