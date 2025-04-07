using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_7
{
    public class CourseRiziq
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class CourseListRiziq
    {
        [JsonPropertyName("courses")]
        public List<CourseRiziq> Courses { get; set; }
    }

    public class KuliahMahasiswa103022300119
    {
        public static void ReadJSON()
        {

            string filePath = @"../../../tp7_2_103022300119.json"; 
            string jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            CourseListRiziq data = JsonSerializer.Deserialize<CourseListRiziq>(jsonString, options);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var course in data.Courses)
            {
                Console.WriteLine($"MK {i} {course.Code} - {course.Name}");
                i++;
            }
        }
    }
}
