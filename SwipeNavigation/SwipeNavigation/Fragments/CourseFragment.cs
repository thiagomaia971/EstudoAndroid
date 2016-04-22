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
        
        private ImageView[] mImageCourses;
        private ListView mLvCourser;
        private int[] coursesImages;

        public Course[] Courses;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            


        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.CourseFragment, container, false);

            // Init the components
                
                mImageCourses = new ImageView[4];
                mImageCourses[0] = view.FindViewById<ImageView>(Resource.Id.imageCourse0);
                mImageCourses[1] = view.FindViewById<ImageView>(Resource.Id.imageCourse1);
                mImageCourses[2] = view.FindViewById<ImageView>(Resource.Id.imageCourse2);
                mImageCourses[3] = view.FindViewById<ImageView>(Resource.Id.imageCourse3);

                mImageCourses[0].Click += delegate { click(view, mImageCourses[0]); };
                mImageCourses[1].Click += delegate { click(view, mImageCourses[1]); };
                mImageCourses[2].Click += delegate { click(view, mImageCourses[2]); };
                mImageCourses[3].Click += delegate { click(view, mImageCourses[3]); };

                for (int i = 0; i < Courses.Length; i++)
                {
                    mImageCourses[i].SetImageResource(ResourceHelper.TranslateDrawableWithReflection(Courses[i].Image));
                }

            return view;
        }

        private void click(View v, View t)
        {
            ImageView a = v.FindViewById<ImageView>(t.Id);
            a.Visibility = ViewStates.Invisible;
            Log.Info("LOG", "Test ");
        }
    }
}