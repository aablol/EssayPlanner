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

namespace EssayPlanner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string user = Username.Text;
            string pass = Password.Text;

            if(pass == "debate")
            {
                
                Intro dashboard = new Intro();
                dashboard.Show();
                dashboard.user(user);
            }
            else
            {
                MessageBox.Show("Login Failed: Incorrect Credientials.");
            }
        }
    }
}
