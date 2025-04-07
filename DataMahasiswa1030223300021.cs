using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace tpmodul7_kelompok_7
{
    public class Nama
    {
        [JsonPropertyName("depan")]
        public string Depan { get; set; }

        [JsonPropertyName("belakang")]
        public string Belakang { get; set; }
    }

    public class Mahasiswa
    {
        [JsonPropertyName("nama")]
        public Nama Nama { get; set; }

        [JsonPropertyName("nim")]
        public long Nim { get; set; }

        [JsonPropertyName("fakultas")]
        public string Fakultas { get; set; }
    }
    class DataMahasiswa1030223300021
    {
        public static void ReadJSON()
        {
            string filePath = @"../../../tp7_1_1030223300021.json";
            string jsonString = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonString, options);

            Console.WriteLine($"Nama {data.Nama.Depan} {data.Nama.Belakang} dengan nim {data.Nim} dari fakultas {data.Fakultas}");
        }

    }
}
