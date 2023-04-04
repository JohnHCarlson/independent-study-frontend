using System.Text.Json.Serialization;

namespace Pindex.Data {

    public class Office {

        public Office(string name) {
            Name = name;
        }

        //PK
        [JsonPropertyName("officeId")]
        public int OfficeId { get; set; }

        //Per-office data
        [JsonPropertyName("name")]
        public string Name { get; set; }

        //Many-to-one data
        [JsonPropertyName("itemId")]
        public int ItemId { get; set; }
        public Item? Item { get; set; }
    }
}
