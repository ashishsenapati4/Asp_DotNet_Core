using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for DataBindingWindow.xaml
    /// </summary>
    public partial class DataBindingWindow : Window, INotifyPropertyChanged
    {
        public DataBindingWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        private string bindText;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string BindText
        {
            get { return bindText; }
            set { 
                bindText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BindText"));
                OnPropertyChanged();
            }
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            BindText = "Update from Code";
        }
        private void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
