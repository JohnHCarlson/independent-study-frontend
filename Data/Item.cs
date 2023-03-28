using System.Text.Json.Serialization;

namespace Pindex.Data {

    public class Item {

        public Item() {
            this.Canorgs = new List<Canorg>();
            this.Offices = new List<Office>();
            this.Locations = new List<Location>();
            this.Parties = new List<Party>();
            this.Categorizations = new List<Categorization>();
            this.Issues = new List<Issue>();
        }

        //PK
        [JsonPropertyName("itemId")]
        public int ItemId { get; set; }

        //Per-item data
        [JsonPropertyName("electionYear")]
        public String? ElectionYear { get; set; }
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
        [JsonPropertyName("won")]
        public bool? Won { get; set; }
        [JsonPropertyName("storageLocation")]
        public string? StorageLocation { get; set; }
        [JsonPropertyName("notes")]
        public string? Notes { get; set; }
        [JsonPropertyName("electionType")]
        public string? ElectionType { get; set; }

        //One-to-one data
        [JsonPropertyName("image")]
        public Image? Image { get; set; }

        //One-to-many data
        [JsonPropertyName("canorgs")]
        public List<Canorg>? Canorgs { get; set; }
        [JsonPropertyName("offices")]
        public List<Office>? Offices { get; set; }
        [JsonPropertyName("locations")]
        public List<Location>? Locations { get; set; }
        [JsonPropertyName("parties")]
        public List<Party>? Parties { get; set; }

        //Many-to-many data
        [JsonPropertyName("categorizations")]
        public List<Categorization>? Categorizations { get; set; }
        [JsonPropertyName("issues")]
        public List<Issue>? Issues { get; set; }
        
    }
}
