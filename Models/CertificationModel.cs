using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14CompetitionTaskProjectMars.Models
{
    public class CertificationModel
    {
        public string TestCaseId { get; set; }
        public string certificationName { get; set; }
        public string certificationFrom { get; set; }
        public string CertificationYear { get; set; }
        public string certificationNameDelete { get; set; }
        public string certificationNameEdit { get; set; }
        public string certificationFromEdit { get; set; }
        public string CertificationYearEdit { get; set; }
        public string certificationNameDeleteEdit { get; set; }
        public string certificationName2 { get; set; }
    }
    public class TestDataCertification
    {
        public List<CertificationModel> Certification { get; set; }

    }
}
