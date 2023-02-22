using System.Text.Json.Serialization;

namespace Pindex.Data {

    public class Item {

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
        public ICollection<Canorg>? Canorgs { get; set; }
        [JsonPropertyName("offices")]
        public ICollection<Office>? Offices { get; set; }
        [JsonPropertyName("locations")]
        public ICollection<Location>? Locations { get; set; }
        [JsonPropertyName("parties")]
        public ICollection<Party>? Parties { get; set; }

        //Many-to-many data
        [JsonPropertyName("categorizations")]
        public ICollection<Categorization>? Categorizations { get; set; }
        [JsonPropertyName("issues")]
        public ICollection<Issue>? Issues { get; set; }
        
    }
}
