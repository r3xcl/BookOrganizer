using BookOrganizer.Views;
using Prism.Mvvm;
using System.Windows.Input;
using Prism.Commands;
using System.Windows.Data;

using System;

namespace BookOrganizer.ViewModels
{
 class MainViewModel : BindableBase
    {
      

        public ICommand ShowSettings
        {
            get;
            private set;
        }
        public MainViewModel()
        {
            ShowSettings = new DelegateCommand(ShowMethod);
        }
        private void ShowMethod()
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.Show();
        }
    }


}
