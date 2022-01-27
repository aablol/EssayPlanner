using SetContinueWorkFromAddColleges.Events;
using SetContinueWorkFromAddColleges.Models;
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
    /// Interaction logic for ContinueWork.xaml
    /// </summary>
    public partial class ContinueWork : Window
    {

        List<CollegesModel> Colleges = new List<CollegesModel>();

        public ContinueWork()
        {
            InitializeComponent();
        }

        private void ContinueWork_Load(object sender, EventArgs e)
        {
            Colleges = CollegesModel.GetColleges();

            this.PopulateColleges();
        }

        private void PopulateCustomers()
        {
            var colleges = (from c in Colleges select c.College).ToList();

            this.lstColleges.DataSource = colleges;

        }

        private void    
    }
}
