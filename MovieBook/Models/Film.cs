using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MovieBook.Stores;
using MovieBook.Commands;
using MovieBook.Database;

namespace MovieBook.Models
{
    public class Film
    {
        DatabaseContextDataContext db;
        public Film(string imagePath, string title, string productionYear, string director)
        {
            this.imagePath = imagePath;
            this.title = title;
            this.productionYear = productionYear;
            this.director = director;

          
        }

        public Film(string imagePath, string title, string productionYear, string director, string descrption)
        {
            this.imagePath = imagePath;
            this.title = title;
            this.productionYear = productionYear;
            this.director = director;
            this.descrption = descrption;
        }

        public Film()
        {

        }

        public string imagePath { get; set; }
        public string title { get; set; }
        public string productionYear { get; set; }
        public string director{ get; set; }
        public string descrption { get; set; }


      public List<Film> getAllFilms()
        {
            db = new DatabaseContextDataContext();
            List<Film> allFilms = new List<Film>();

            var get = from t in db.Film select t;

            get.ToList().ForEach(film => allFilms.Add(new Film(film.imagePath, film.title, film.productionYear, film.director, film.descrption)));

            return allFilms;
        }




    }
}
