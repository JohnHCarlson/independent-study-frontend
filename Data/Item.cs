﻿namespace Pindex.Data {

    public class Item {

        //PK
        public int ItemId { get; set; }

        //Per-item data
        public DateTime? ElectionDate { get; set; }
        public int Quantity { get; set; }
        public bool? Won { get; set; }
        public string? StorageLocation { get; set; }
        public string? Notes { get; set; }
        public string? ElectionType { get; set; } 
        
        //One-to-one data
        public Image? Image { get; set; }

        //One-to-many data
        public ICollection<Canorg>? Canorgs { get; set; }
        public ICollection<Office>? Offices { get; set; }
        public ICollection<Location>? Locations { get; set; }
        public ICollection<Party>? Parties { get; set; }

        //Many-to-many data
        public ICollection<Categorization>? Categorizations { get; set; }
        public ICollection<Issue>? Issues { get; set; }
        
    }
}
