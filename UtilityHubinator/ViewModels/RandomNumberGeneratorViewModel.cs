using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilitiesCore;
using UtilityHubinator.Commands;

namespace UtilityHubinator.ViewModels
{
    public class RandomNumberGeneratorViewModel : BaseViewModel
    {
        private int _lowerRange;
        private int _upperRange;
        private int _randomNumber;

        public int LowerRange
        {
            get => _lowerRange;
            set
            {
                if (_lowerRange != value)
                {
                    _lowerRange = value;
                    OnPropertyChanged();
                }
            }
        }

        public int UpperRange
        {
            get => _upperRange;
            set
            {
                if (_upperRange != value)
                {
                    _upperRange = value;
                    OnPropertyChanged();
                }
            }
        }

        public int RandomNumber
        {
            get => _randomNumber;
            set
            {
                if (_randomNumber != value)
                {
                    _randomNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand ShowGenerateRandomNumberCommand { get; }
        
        public RandomNumberGeneratorViewModel()
        {
            ShowGenerateRandomNumberCommand = new RelayCommand(_ => GenerateNumber());
        }

        public void GenerateNumber()
        {
            RandomNumber = RandomNumberGenerator.GenerateNumber(_lowerRange, _upperRange);
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected override void Clear()
        {
            LowerRange = 0;
            UpperRange = 0;
            RandomNumber = 0;
        }
    }
}
