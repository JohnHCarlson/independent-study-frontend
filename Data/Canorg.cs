using System.Text.Json.Serialization;

namespace Pindex.Data {
    public class Canorg {

        public Canorg(string name) {
            Name = name;
        }

        //PK
        [JsonPropertyName("canorgId")]
        public int CanorgId { get; set; }

        //Per-canorg data
        [JsonPropertyName("name")]
        public string Name { get; set; }

        //Many-to-one data
        [JsonPropertyName("itemId")]
        public int ItemId { get; set; }
        
        public Item? Item { get; set; }
    }
}
