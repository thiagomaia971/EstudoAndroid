using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Course
    {
        public string Description { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }

        public Course()
        {

        }

        public Course(string Title, string Description, string Image)
        {
            this.Title = Title;
            this.Description = Description;
            this.Image = Image;
        }
    }
}
