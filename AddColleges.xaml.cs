﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using SetContinueWorkFromAddColleges.Events;
using SetContinueWorkFromAddColleges.Models;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EssayPlanner
{
    /// <summary>
    /// Interaction logic for AddColleges.xaml
    /// </summary>
    public partial class AddColleges : Window
    {
        public delegate void CollegesHandler(object sender, UpdateCollegesEventArgs e);

        public event CollegesHandler UpdateColleges;

        public List<CollegesModel> Customers;
            
        public AddColleges()
        {
            InitializeComponent();
        }
        

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            UpdateCollegesEventArgs args = new UpdateCollegesEventArgs(Colleges);

            UpdateColleges(this, args);

            this.Close();
        }

        private void addColleges_Click(object sender, RoutedEventArgs e)
        {
            if(!this.PerformValidation())
            {
                return;
            }
            this.AddCollege();

        }

        private void AddCollege()
        {
            Colleges.Add(new CollegesModel()
            {
                Colleges = this.College_Box.Text.Trim()
            });

            MessageBox.Show("Customer succesfully added!", TitlesModel.MessageBoxTitle,
                                MessageBoxButtons.OK, Messagebox)
        }

    }
}
