﻿using System;
using System.Data;
using System.Threading.Tasks;
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            user.InsertQuery(nametabl.Text, emailtabl.Text);
            usersGrid.ItemsSource = user.GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int id = (int)(usersGrid.SelectedItem as DataRowView).Row[0];
            user.DeleteQuery(id);

            usersGrid.ItemsSource = user.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (usersGrid.SelectedItem != null)
            {
                int id = (int)(usersGrid.SelectedItem as DataRowView).Row[0];
                user.UpdateQuery(nametabl.Text, emailtabl.Text, id);
                usersGrid.ItemsSource = user.GetData();
            }
        }

        private void UsersGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (usersGrid.SelectedItem != null)
            {
                var vibor = usersGrid.SelectedItem as DataRowView;
                nametabl.Text = (string)vibor.Row[1];
                emailtabl.Text = (string)vibor.Row[2];
            }
        }
    }
}
