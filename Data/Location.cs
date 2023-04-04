using System.Text.Json.Serialization;

namespace Pindex.Data {

    public class Location {

        public Location(string name) {
            Name = name;
        }

        //PK
        [JsonPropertyName("locationId")]
        public int LocationId { get; set; }

        //Per-location data
        [JsonPropertyName("name")]
        public string Name { get; set; }

        //Many-to-one data
        [JsonPropertyName("itemId")]
        public int ItemId { get; set; }
        public Item? Item { get; set; }
    }
}

