using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetContinueWorkFromAddColleges.Models
{
    public class CollegesModel
    {
        public string College { get; set; }

        public CollegesModel()
        {

        }

        public CollegesModel(string c)
        {
            College = c;
        }

        public static List<CollegesModel> GetColleges()
        {
            return new List<CollegesModel>();
            
        }




    }
}
