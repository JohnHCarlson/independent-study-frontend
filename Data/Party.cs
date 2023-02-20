namespace Pindex.Data {
    public class Party {

        //PK
        public int PartyId { get; set; }

        //Per-issue data
        public required string Name { get; set; }

        //Many-to-one data
        public int ItemId { get; set; }
        public Item? Item { get; set; }
    }
}
