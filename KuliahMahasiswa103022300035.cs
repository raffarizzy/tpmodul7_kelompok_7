﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_7
{
    public class CourseBagas
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class CourseListBagas
    {
        [JsonPropertyName("courses")]
        public List<CourseBagas> Courses { get; set; }
    }

    public class KuliahMahasiswa1030223300035
    {
        public static void ReadJSON()
        {

            string filePath = @"../../../tp7_2_103022300035.json";
            string jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            CourseListBagas data = JsonSerializer.Deserialize<CourseListBagas>(jsonString, options);

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

