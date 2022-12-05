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

namespace gallery
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int NumPict = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoNext(object sender, RoutedEventArgs e)
        {
            NumPict--;
            if (NumPict == 0)
            {
                NumPict = 10;
            }
            ImageArea.Source = new BitmapImage(new Uri("Images/" + NumPict + ".png", UriKind.Relative));

        }

        private void GoBack(object sender, RoutedEventArgs e)
        {
            NumPict++;
            if (NumPict == 11)
            {
                NumPict = 1;
            }
            ImageArea.Source= new BitmapImage(new Uri("Image/" + NumPict + ".png",UriKind.Relative));
        }
    }
}
