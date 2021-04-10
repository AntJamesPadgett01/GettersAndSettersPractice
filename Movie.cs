using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSettersPractice
{
    class Movie
    {
        public string title;
        public string director;
        private string rating; 


        public Movie(string aTitle, String aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating // properties
        {
            get { return rating; }
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NC-17") 

                {
                    rating = value;
                }
                 else
                {
                    rating = "NR";
                }


            }
        }

    }
}
