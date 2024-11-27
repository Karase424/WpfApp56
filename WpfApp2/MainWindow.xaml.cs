using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            this.Close();
        }

        private void Radiobtn1_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["MyImageSource"] = new BitmapImage(new Uri(@"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\Kalina_06\Desktop\фото\fox.jpg"));
        }

        private void Radiobtn2_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["MyImageSource"] = new BitmapImage(new Uri(@"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\Kalina_06\Desktop\фото\kitty.jpg"));
        }

        private void Radiobtn3_Checked(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["MyImageSource"] = new BitmapImage(new Uri(@"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\Kalina_06\Desktop\фото\Shrek.jpg"));
        }
    }
}
