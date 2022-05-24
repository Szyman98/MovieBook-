using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieBook.Stores;
using MovieBook.ViewsModel;

namespace MovieBook.Commands
{
    public class backToFilmListCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new FilmListViewModel(_navigationStore);
        }



        public backToFilmListCommand(NavigationStore navigation)
        {
            _navigationStore = navigation;
        }
    }
}
