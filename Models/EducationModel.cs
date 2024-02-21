using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14CompetitionTaskProjectMars.Models
{
    public class EducationModel
    {
        public string TestCaseId { get; set; }
        public string universityName { get; set; }
        public string country { get; set; }
        public string title { get; set; }
        public string degree { get; set; }
        public string yearOfGraduate { get; set; }
        public string universityNameDelete { get; set; }
        public string universityNameEdit { get; set; }
        public string countryEdit { get; set; }
        public string titleEdit { get; set; }
        public string degreeEdit { get; set; }
        public string yearOfGraduateEdit { get; set; }
        public string universityNameDeleteEdit { get; set; }
        public string universityName2 { get; set; }
        public string universityNameEdit2 { get; set; }
    }
    public class TestDataEducation
    {
        public List<EducationModel> Education { get; set; }

    }

}
