namespace Pindex.Data {
    public class Image {

        //PK
        public int ImageId { get; set; }
        
        //Per-image data
        public DateTime UploadDate { get; set; }
        public string FileName { get; set; }
        
        //One-to-one data
        public int ItemId { get; set; }
        public Item? Item { get; set; }
    }
}
