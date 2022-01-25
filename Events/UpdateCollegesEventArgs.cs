using SetContinueWorkFromAddColleges.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetContinueWorkFromAddColleges.Events
{
    public class UpdateCollegesEventArgs : EventArgs
    {
        private List<CollegesModel> colleges = new List<CollegesModel>();
        
        public UpdateCollegesEventArgs(List<CollegesModel> c)
        {
            colleges = c;
        }

        public List<CollegesModel> GetColleges
        {
            get { return colleges; }
        }
    }
}
