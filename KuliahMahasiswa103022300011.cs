﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_7
{
    public class CourseFrizam
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class CourseListFrizam
    {
        [JsonPropertyName("courses")]
        public List<CourseFrizam> Courses { get; set; }
    }

    public class KuliahMahasiswa103022300011
    {
        public static void ReadJSON()
        {

            string filePath = @"../../../tp7_2_103022300011.json"; 
            string jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            CourseListFrizam data = JsonSerializer.Deserialize<CourseListFrizam>(jsonString, options);

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
