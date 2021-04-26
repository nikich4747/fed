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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for fed1.xaml
    /// </summary>
    public partial class fed1 : UserControl
    {
        public fed1()
        {
            InitializeComponent();
        }


        public ImageSource ImageSource
        {
            get { return fed.Source; }
            set { fed.Source = value; }
        }
        public String Title
        {
            get { return title.Text; }
            set { title.Text = value; }
        }
        public String Desription
        {
            get { return description.Text; }
            set { description.Text = value; }
        }
        public String Price
        {
            get { return price.Text; }
            set { price.Text = value; }
        }

        public Boolean status
        {
            get { return Status.IsEnabled; }
            set { Status.IsEnabled = value; }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
    
