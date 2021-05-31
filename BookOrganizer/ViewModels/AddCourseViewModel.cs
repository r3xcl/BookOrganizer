
using BookOrganizer.Commands;
using BookOrganizer.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BookOrganizer.ViewModels
{
    class AddCourseViewModel : ViewModelBase
    {
        public ICommand NavigateHomeCommand { get; }

        public AddCourseViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore));
        }
    }
}
