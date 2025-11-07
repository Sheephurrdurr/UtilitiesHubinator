using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using UtilityHubinator.Commands;

namespace UtilityHubinator.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? name = null) 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public ICommand ClearCommand { get; }
        protected BaseViewModel()
        {
            ClearCommand = new RelayCommand(_ => Clear());
        }
        protected abstract void Clear();
    }
}
