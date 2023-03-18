using System.Windows;
using System.Windows.Controls;

namespace PraktikaP6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new First_page();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Second_page();
        }
    }
}
