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
using System.Windows.Shapes;

namespace WPFTutorial
{
    /// <summary>
    /// Interaction logic for MessageBox.xaml
    /// </summary>
    public partial class MessageBoxWindow : Window
    {
        public MessageBoxWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("Could not open file","ERROR",MessageBoxButton.OKCancel,MessageBoxImage.Error);

            MessageBoxResult result = MessageBox.Show("Do you agree?", "Agreement", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                tbInfo.Text = "Agreed";
            }
            else
            {
                tbInfo.Text = "Not Agreed";
            }
        }
    }
}
