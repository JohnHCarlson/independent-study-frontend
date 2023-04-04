using System.Text.Json.Serialization;

namespace Pindex.Data {
    public class Party {

        public Party(string name) {
           Name = name;
        }

        //PK
        [JsonPropertyName("partyId")]
        public int PartyId { get; set; }

        //Per-issue data
        [JsonPropertyName("name")]
        public string Name { get; set; }

        //Many-to-one data
        [JsonPropertyName("itemId")]
        public int ItemId { get; set; }
        public Item? Item { get; set; }
    }
}
