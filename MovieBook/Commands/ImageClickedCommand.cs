using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieBook.Models;
using MovieBook.Stores;
using MovieBook.ViewsModel;

namespace MovieBook.Commands
{
    public class ImageClickedCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        public override void Execute(object parameter)
        {
           Film selectedFilm = parameter as Film;

            _navigationStore.CurrentViewModel = new FilmViewModel(_navigationStore, selectedFilm);
            

        }


        public ImageClickedCommand(NavigationStore navigation)
        {
            _navigationStore = navigation;
        }
    }
}
