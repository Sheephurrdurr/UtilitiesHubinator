using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using UtilityHubinator.Commands;

namespace UtilityHubinator.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private object _currentViewModel;
        private readonly AgeConverterViewModel _ageConverterVM = new AgeConverterViewModel();

        public ICommand ShowAgeConverterCommand { get; }

        public object CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                if (_currentViewModel != value)
                {
                    _currentViewModel = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainViewModel(bool autoInit = true)
        {
            ShowAgeConverterCommand = new RelayCommand(_ => CurrentViewModel = _ageConverterVM);
            if (autoInit) CurrentViewModel = _ageConverterVM;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null) 
        { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
