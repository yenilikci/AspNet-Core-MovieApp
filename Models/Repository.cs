using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models 
{
    public static class Repository
    {
        private static List<Movie> _movies = null;

        static Repository()
        {
            _movies = new List<Movie>
            {
                new Movie(){ Id=1,Name="Esaretin Bedeli",Description="Esaretin Bedeli",ImageUrl="1.jpg" },
                new Movie(){ Id=2,Name="Baba",Description="Baba",ImageUrl="2.jpg" },
                new Movie(){ Id=3,Name="Kara Şövalye",Description="Kara Şövalye",ImageUrl="3.jpg" },
                new Movie(){ Id=4,Name="Dövüş Kulübü",Description="Dövüş Kulübü",ImageUrl="4.jpg" },
                new Movie(){ Id=5,Name="Forrest Gump",Description="Forrest Gump",ImageUrl="5.jpg" },


            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}
