using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieBook.Stores;
using System.Windows.Input;
using MovieBook.Commands;
using MovieBook.Models;

namespace MovieBook.ViewsModel
{
    public  class FilmViewModel : ViewModelBase
    {

        public Film film { get; }

        
        
        public FilmViewModel(NavigationStore navigationStore, Film selectedObject)
        {
            backToFilmList = new backToFilmListCommand(navigationStore);
            
            film = selectedObject;

        }

      



        

        public ICommand backToFilmList { get; }



    }
}
