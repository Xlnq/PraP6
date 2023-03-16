using System.Windows;
using System.Windows.Controls;
using PraktikaP6.PraktikaLoveDataSetTableAdapters;

namespace PraktikaP6
{
    public partial class First_page : Page
    {
        usersTableAdapter user = new usersTableAdapter();
        public First_page()
        {
            InitializeComponent();
            usersGrid.ItemsSource = user.GetData();
        }
    }
}
