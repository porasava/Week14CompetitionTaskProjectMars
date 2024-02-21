using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Week14CompetitionTaskProjectMars.Models; // Import the namespace for LoginModel and TestData

namespace Week14CompetitionTaskProjectMars.Utilities
{
    public static class JsonReader
    {
        public static List<LoginModel> ReadLoginData(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var testData = JsonSerializer.Deserialize<TestData>(jsonString);

            if (testData != null && testData.Login.Any())
            {
                return testData.Login;
            }
            else
            {
                // Handle the case where no data is found or return an empty list
                return new List<LoginModel>();
            }
        }

        public static List<EducationModel> ReadEducationData(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var testData = JsonSerializer.Deserialize<TestDataEducation>(jsonString);

            if (testData != null && testData.Education.Any())
            {
                return testData.Education;
            }
            else
            {
                // Handle the case where no data is found or return an empty list
                return new List<EducationModel>();
            }
        }

        public static List<CertificationModel> ReadCertificationData(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var testData = JsonSerializer.Deserialize<TestDataCertification>(jsonString);

            if (testData != null && testData.Certification.Any())
            {
                return testData.Certification;
            }
            else
            {
                // Handle the case where no data is found or return an empty list
                return new List<CertificationModel>();
            }
        }
    }
}
