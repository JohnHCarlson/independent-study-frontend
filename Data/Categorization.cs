using System.Text.Json.Serialization;

namespace Pindex.Data {

    public class Categorization {

        public Categorization(string name) { 
            Name = name;
        }

        //PK
        [JsonPropertyName("categorizationId")]
        public int CategorizationId { get; set; }

        //Per-categorization data
        [JsonPropertyName("name")]
        public string Name { get; set; }

        //Many-to-many data
        public ICollection<Item>? Items { get; set; }
    }
}

