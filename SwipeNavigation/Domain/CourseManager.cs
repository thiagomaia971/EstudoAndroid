﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CourseManager
    {
        private readonly Course[] courses;

        int currentIndex = 0;
        private readonly int lastIndex;
        public Boolean CanMovePrev { get { return currentIndex > 0; } }
        public Boolean CanMoveNext { get { return currentIndex < lastIndex; } }
        public int Length { get { return courses.Length; } }

        public CourseManager()
        {
            courses = InitCourses();
            lastIndex = courses.Length - 1;
        }

        private Course[] InitCourses()
        {
            var initCourses = new Course[] {
                new Course()
                {
                    Title = "Android for .NET Developers",
                    Description = "Provides an overview of the tools used in the Android " +
                    "development process including the newly released Android Studio.",
                    Image = "ps_top_card_00"
                },

                new Course()
                {
                    Title = "Android Dreams, Widgets, Notifications",
                    Description = "Provide users with a rich and interactive experience " +
                    "without ever requiring them to open your app.",
                    Image = "ps_top_card_01"
                },
                new Course()
                {
                    Title = "Android Photo/Video Programming",
                    Description = "Learn how to capitalize on the Android camera " +
                    "within your apps to capture still photos and video.",
                    Image = "ps_top_card_02"
                },
                new Course()
                {
                    Title = "Android Location-Based Apps",
                    Description = "Cover the wide range of Android location capabilities " +
                    "including determining user location, power management, and " +
                    "translating location data to human-readable addresses.",
                    Image = "ps_top_card_03"
                },
                new Course()
                {
                    Title = "Android Location-Based Apps",
                    Description = "Cover the wide range of Android location capabilities " +
                    "including determining user location, power management, and " +
                    "translating location data to human-readable addresses.",
                    Image = "ps_top_card_00"
                },
                new Course()
                {
                    Title = "Android Location-Based Apps",
                    Description = "Cover the wide range of Android location capabilities " +
                    "including determining user location, power management, and " +
                    "translating location data to human-readable addresses.",
                    Image = "ps_top_card_01"
                },
                new Course()
                {
                    Title = "Android Location-Based Apps",
                    Description = "Cover the wide range of Android location capabilities " +
                    "including determining user location, power management, and " +
                    "translating location data to human-readable addresses.",
                    Image = "ps_top_card_02"
                }

            };

            return initCourses;
        }


        public void MoveFirst()
        {
            currentIndex = 0;
        }

        public void MoveTo(int position)
        {
            if (position >= 0 && position <= lastIndex)
            {
                if (position < currentIndex)
                {
                    currentIndex -= 3;
                }
                else if (position > currentIndex)
                {
                    currentIndex += 3;

                }
            }
            else
            {
                throw new IndexOutOfRangeException(
                    String.Format("{0} is an invalid position. Must be between 0 and {1}",
                    position, lastIndex));
            }
        }


        public Course[] currentCourses()
        {
            Course[] coursesToPrint = new Course[4];
            Course withImageEmpty = new Course() { Image = "Icon" };
            
            for (int i = 0; i < coursesToPrint.Length; i++)
            {
                if(currentIndex < courses.Length)
                {
                    coursesToPrint[i] = courses[currentIndex];
                    currentIndex++;
                }
                else
                {
                    coursesToPrint[i] = withImageEmpty;
                }
            }
            return coursesToPrint;
        }
        
    }
}