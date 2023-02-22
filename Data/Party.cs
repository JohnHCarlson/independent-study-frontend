using System.Text.Json.Serialization;

namespace Pindex.Data {
    public class Party {

        //PK
        [JsonPropertyName("partyId")]
        public int PartyId { get; set; }

        //Per-issue data
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        //Many-to-one data
        [JsonPropertyName("itemId")]
        public int ItemId { get; set; }
        public Item? Item { get; set; }
    }
}
