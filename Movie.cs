using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setter_getter
{
    internal class Movie
    {
        public string movieName;
        public string creator;
        public string rating;

        public Movie(string mN, string c, string r)
        {
            movieName = mN;
            creator = c;
            Rating = r;
        }

        public string Rating
        {
            get { return rating; }
            set {
                if(value == "PG" || value == "PG-13" || value == "G" || value == "R")
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
