﻿using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tpmodul7_kelompok_7
{
    public class NamaBagas
    {
        [JsonPropertyName("depan")]
        public string Depan { get; set; }

        [JsonPropertyName("belakang")]
        public string Belakang { get; set; }
    }

    public class MahasiswaBagas
    {
        [JsonPropertyName("nama")]
        public NamaBagas Nama { get; set; }

        [JsonPropertyName("nim")]
        public long Nim { get; set; }

        [JsonPropertyName("fakultas")]
        public string Fakultas { get; set; }
    }

    public class DataMahasiswa103022300035
    {
        public static void ReadJSON()
        {
                string filePath = @"../../../tp7_1_103022300035.json";
                string jsonString = File.ReadAllText(filePath);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                MahasiswaBagas data = JsonSerializer.Deserialize<MahasiswaBagas>(jsonString, options);

                Console.WriteLine($"Nama {data.Nama.Depan} {data.Nama.Belakang} dengan nim {data.Nim} dari fakultas {data.Fakultas}");
        }
    }
}
