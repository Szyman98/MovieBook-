using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieBook.Models;
using MovieBook.Stores;
using System.Windows.Input;
using MovieBook.Commands;
using MovieBook.Models;
using System.Windows.Controls;
using System.Windows.Media;

namespace MovieBook.ViewsModel
{
    public class FilmListViewModel : ViewModelBase
    {
        Film film;
  

        public FilmListViewModel(NavigationStore navigationStore)
        {

            film = new Film();

            Films = film.getAllFilms();             

            ImageOnClick = new ImageClickedCommand(navigationStore);

        }

        public ICommand ImageOnClick { get; }

        public List<Film> Films {  get; set; }
    }
}
