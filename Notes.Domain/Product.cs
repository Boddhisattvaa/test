namespace Notes.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Namaer { private get; set; }
        public string Description { private get; set; }
        public string Category { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string DescriptionId { get; set; }
        = string.Empty;
        public string DescriptionName { get; set; }

        public string DescriptionDescription { get; set; } = string.Empty;

    }
}
