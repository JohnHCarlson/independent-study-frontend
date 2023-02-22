using System.Text.Json.Serialization;

namespace Pindex.Data {

    public class Office {

        //PK
        [JsonPropertyName("officeId")]
        public int OfficeId { get; set; }

        //Per-office data
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        //Many-to-one data
        [JsonPropertyName("itemId")]
        public int ItemId { get; set; }
        public Item? Item { get; set; }
    }
}
