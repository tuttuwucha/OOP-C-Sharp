using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp11
{
    class Movie
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public Movie(string title = "", int duration = 0)
        {
            Title = title;
            Duration = duration;
        }
    }
}
