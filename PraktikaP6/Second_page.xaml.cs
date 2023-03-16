using System.Windows.Controls;
using PraktikaP6.PraktikaLoveDataSetTableAdapters;

namespace PraktikaP6
{
    public partial class Second_page : Page
    {
        tasksTableAdapter task = new tasksTableAdapter();
        public Second_page()
        {
            InitializeComponent();
            tasksGrid.ItemsSource = task.GetData();
        }
    }
}
