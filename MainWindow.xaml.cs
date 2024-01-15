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

namespace DataBindingCollections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<DisplaysViewModel>? CollectionOne { get; set; }
        public List<DisplaysViewModel>? CollectionTwo { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Pull Custom Text from File using IO instead
            View1.DisplaysViewModels = new List<DisplaysViewModel>
            {
                new DisplaysViewModel
                {
                    HeaderText = "Custom Text 1",
                    InputOutput = true
                },
                new DisplaysViewModel
                {
                    HeaderText = "Custom Text 2",
                    InputOutput = false
                },
                new DisplaysViewModel
                {
                    HeaderText = "Custom Text 3",
                    InputOutput = false
                },
            };

            View2.DisplaysViewModels = new List<DisplaysViewModel>
            {
                new DisplaysViewModel
                {
                    HeaderText = "Kustom Text 1",
                    InputOutput = true
                },
                new DisplaysViewModel
                {
                    HeaderText = "Kustom Text 2",
                    InputOutput = false
                },
                new DisplaysViewModel
                {
                    HeaderText = "Kustom Text 3",
                    InputOutput = false
                },
                new DisplaysViewModel
                {
                    HeaderText = "Kustom Text 4",
                    InputOutput = false
                },
            };
        }
    }
}