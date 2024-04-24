using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater
{
    internal class MovieTheater
    {
        List<Movie> Movies { get; set; }
        
        int? NumMovies { get; set; }

        public void AddMovie() { 
            Movie m1 = new();

            Console.WriteLine("Enter Movie Name : ");
            m1.Name = Console.ReadLine();

            Console.WriteLine("Enter Movie Genre : ");
            m1.Genre = Console.ReadLine();  
        }
    }
}
