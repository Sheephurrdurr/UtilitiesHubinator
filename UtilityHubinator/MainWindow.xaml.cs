using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using UtilityHubinator.ViewModels;

namespace UtilityHubinator
{
    /// <summary>
    /// Solution provides easy access to the first 5 challenge solutions, from the "100 Programming Challenges"-image
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var vm = new MainViewModel(false);
            DataContext = vm;
        }
    }
}