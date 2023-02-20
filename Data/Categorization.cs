namespace Pindex.Data {

    public class Categorization {

        //PK
        public int CategorizationId { get; set; }

        //Per-categorization data
        public required string Name { get; set; }

        //Many-to-many data
        public ICollection<Item>? Items { get; set; }
    }
}

