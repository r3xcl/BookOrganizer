using BookOrganizer.Commands;
using BookOrganizer.Stores;
using BookOrganizer.Views;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BookOrganizer.ViewModels
{
    class HomeViewModel : ViewModelBase
    {
        public ICommand NavigateAddCourseCommand { get; }
        public ICommand ShowSettings
        {
            get;
            private set;
        }
        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateAddCourseCommand = new NavigateCommand<AddCourseViewModel>(navigationStore, () => new AddCourseViewModel(navigationStore));
            ShowSettings = new DelegateCommand(ShowMethod);
        }
        private void ShowMethod()
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.Show();
        }
    }
}
