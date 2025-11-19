using Microsoft.Win32;
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
    /// Interaction logic for OpenFileDialogWindow.xaml
    /// </summary>
    public partial class OpenFileDialogWindow : Window
    {
        public OpenFileDialogWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text files | *.txt";
            fileDialog.Title = "Select Text files";
            fileDialog.Multiselect = true;

            bool? success = fileDialog.ShowDialog();
            if (success == true)
            {
                string[] fileNames = fileDialog.FileNames;

                string arr="";

                foreach(string str in fileNames)
                {
                    arr = arr  + str;
                }
                tbInfo.Text = arr;
            }
            else
            {
                tbInfo.Text = "No file chosen";
            }
        }
    }
}
