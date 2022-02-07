using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setter_getter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Tom & Jerry","William","PG-13");
            Movie movie2 = new Movie("The adventure of Tin Tin","Herge","R");

            movie1.Rating = "cat"; //always remember the next line about rating. 
            Console.WriteLine("Valid Rating are PG, PG-13, R, G and non-valid rating is NR.");
            Console.WriteLine(movie1.Rating);
            Console.ReadLine();
        }
    }
}
