using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for ReusableView.xaml
    /// </summary>
    public partial class ReusableView : UserControl
    {
        public List<DisplaysViewModel> DisplaysViewModels { get; set; }
        public ReusableView()
        {
            InitializeComponent();

            DataContext = this;

            DisplaysViewModels = new List<DisplaysViewModel>
            {
                new DisplaysViewModel
                {
                    HeaderText = "Default Text 1",
                    InputOutput = true
                },
                new DisplaysViewModel
                {
                    HeaderText = "Default Text 2",
                    InputOutput = false
                },
            };
        }
    }
}
