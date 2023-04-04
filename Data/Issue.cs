using System.Text.Json.Serialization;

namespace Pindex.Data {

    public class Issue {

        public Issue(string name) {
            Name = name;
        }

        //PK
        [JsonPropertyName("issueId")]
        public int IssueId { get; set; }

        //Per-issue data
        [JsonPropertyName("name")]
        public string Name { get; set; }

        //Many-to-many data
        public ICollection<Item>? Items { get; set; }
    }
}

