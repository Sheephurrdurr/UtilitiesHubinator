using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilityHubinator.Commands;
using UtilitiesCore;

namespace UtilityHubinator.ViewModels
{
    public class AgeConverterViewModel : INotifyPropertyChanged
    {
        private int _years;
        private double _seconds;

        public int Years
        {
            get => _years;
            set
            {
                if (_years != value)
                {
                    _years = value;
                    OnPropertyChanged(nameof(Years));
                }
            }
        }

        public double Seconds
        {
            get => _seconds;
            private set
            {
                if (_seconds != value)
                {
                    _seconds = value;
                    OnPropertyChanged(nameof(Seconds));
                }
            }
        }

        public ICommand ConvertCommand { get; }

        public AgeConverterViewModel()
        {
            ConvertCommand = new RelayCommand(_ => ConvertAge());
        }

        private void ConvertAge()
        {
            Seconds = AgeConverter.ConvertYearsToSeconds(Years);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) => 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
