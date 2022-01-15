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

namespace EssayPlanner
{
    /// <summary>
    /// Interaction logic for Intro.xaml
    /// </summary>
    public partial class Intro : Window
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void Add_Colleges_Click(object sender, RoutedEventArgs e)
        {
            AddColleges addColleges = new AddColleges();
            addColleges.Show();
        }

        private void CommonApps_Click(object sender, RoutedEventArgs e)
        {
            CommonApp commonApps = new CommonApp();
            commonApps.Show();
        }

        private void ApplyTexas_Click(object sender, RoutedEventArgs e)
        {
            ApplyTexas applyTexas = new ApplyTexas();
            applyTexas.Show();
        }

        private void ContinueWork_Click(object sender, RoutedEventArgs e)
        {
            ContinueWork continueWork = new ContinueWork();
            continueWork.Show();
        }

        public void user(string username)
        {
            Label2.Text = "Welcome to the program! " + username;
        }
    }
}
