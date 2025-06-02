using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace cloneCoding.ViewModels
{
    [ObservableObject]
    public partial class MainViewModel
    {
        [ObservableProperty]
        private INotifyPropertyChanged _currentViewModel;

        [RelayCommand]
        public void ToLogin()
        {
            Console.WriteLine("ToLogin called");
            CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(typeof(LoginControlViewModel))!;
        }
        [RelayCommand]
        public void ToChangePwd()
        {
            Console.WriteLine("ToChangePwd called");
            CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(typeof(ChangePwdControlViewModel))!;
        }
        [RelayCommand]
        public void ToSignup()
        {
            Console.WriteLine("ToSignup called");
            CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(typeof(SignupControlViewModel))!;
        }
        public MainViewModel()
        {
            CurrentViewModel = (INotifyPropertyChanged)App.Current.Services.GetService(typeof(LoginControlViewModel))!;
        }
    }
}
