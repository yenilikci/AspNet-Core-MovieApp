﻿using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Data 
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>
            {
                new Movie(){ Id=1,
                    Name="Esaretin Bedeli",
                    ShortDescription="Esaretin Bedeli Filmi",
                    Description="<p><b>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</b></p>",
                    ImageUrl="1.jpg",
                    CategoryId = 5},
                new Movie(){ Id=2,
                    Name="Baba",
                    ShortDescription="Baba Filmi",
                    Description="<p><b>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</b></p>",
                    ImageUrl="2.jpg",
                    CategoryId = 2},
                new Movie(){ Id=3,
                    Name="Kara Şövalye",
                    ShortDescription="Kara Şövalye Filmi",
                    Description="<p><b>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</b></p>",
                    ImageUrl="3.jpg",
                    CategoryId = 3},
                new Movie(){ Id=4,
                    Name="Dövüş Kulübü",
                    ShortDescription="Dövüş Kulübü Filmi",
                    Description="<p><b>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</b></p>",
                    ImageUrl="4.jpg",
                    CategoryId = 2},
                new Movie(){ Id=5,
                    Name="Forrest Gump",
                    ShortDescription="Forrest Gump Filmi",
                    Description="<p><b>Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.</b></p>",
                    ImageUrl="5.jpg",
                    CategoryId = 5},


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
