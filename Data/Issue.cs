using System.Text.Json.Serialization;

namespace Pindex.Data {

    public class Issue {

        //PK
        [JsonPropertyName("issueId")]
        public int IssueId { get; set; }

        //Per-issue data
        [JsonPropertyName("name")]
        public required string Name { get; set; }

        //Many-to-many data
        public ICollection<Item>? Items { get; set; }
    }
}

