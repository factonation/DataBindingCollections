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
    /// Interaction logic for Displays.xaml
    /// </summary>
    public partial class Displays : UserControl
    {
        public List<DisplaysViewModel> DisplaysViewModels
        {
            get { return (List<DisplaysViewModel>)GetValue(DisplaysViewModelsProperty); }
            set { SetValue(DisplaysViewModelsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisplaysViewModels.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisplaysViewModelsProperty =
            DependencyProperty.Register("DisplaysViewModels", typeof(List<DisplaysViewModel>), typeof(Displays), new PropertyMetadata(null));


        public Displays()
        {
            InitializeComponent();

            DataContext = this;
        }
    }
}
