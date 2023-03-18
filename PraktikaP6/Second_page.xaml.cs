using System;
using System.Data;
using System.Windows.Controls;
using PraktikaP6.PraktikaLoveDataSetTableAdapters;

namespace PraktikaP6
{
    public partial class Second_page : Page
    {
        tasksTableAdapter task = new tasksTableAdapter();
        usersTableAdapter user = new usersTableAdapter();
        public Second_page()
        {
            InitializeComponent();
            tasksGrid.ItemsSource = task.GetData();
            idtabl.ItemsSource = user.GetData();
            idtabl.DisplayMemberPath = "name";
            idtabl.SelectedValuePath = "id";
        }

        private void Button_Click_2(object sender, System.Windows.RoutedEventArgs e)
        {
            int iduser = (int)idtabl.SelectedValue;
            task.InsertQuery(nametabl.Text, descriptiontabl.Text, datetabl.Text, iduser);
            tasksGrid.ItemsSource = task.GetData();
        }

        private void Button_Click_3(object sender, System.Windows.RoutedEventArgs e)
        {
            int id = (int)(tasksGrid.SelectedItem as DataRowView).Row[0];
            task.DeleteQuery(id);
            
            tasksGrid.ItemsSource = task.GetData();
        }
    }
}
