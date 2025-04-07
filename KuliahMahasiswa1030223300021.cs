using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_7
{
    public class Course
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class CourseList
    {
        [JsonPropertyName("courses")]
        public List<Course> Courses { get; set; }
    }

    class KuliahMahasiswa1030223300021
    {
        public static void ReadJSON()
        {

            string filePath = @"../../../tp7_2_1030223300021.json";
            string jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            CourseList data = JsonSerializer.Deserialize<CourseList>(jsonString, options);

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
