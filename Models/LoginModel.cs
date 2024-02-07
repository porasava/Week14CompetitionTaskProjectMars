using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Week14CompetitionTaskProjectMars.Models
{
    public class LoginModel
    {
        public string username { get; set; }
        public string password { get; set; }
    }
    public class TestData
    {
        public List<LoginModel> Login { get; set; }

    }



 
}
