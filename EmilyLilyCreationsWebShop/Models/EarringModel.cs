namespace EmilyLilyCreationsWebShop.Models
{
    public class EarringModel
    {
        public string partitionKey { get; set; }
        public string rowKey { get; set; }
        public DateTime timestamp { get; set; }
        public float price { get; set; }
        public string description { get; set; }
        public string colour { get; set; }
        public string imageUrl { get; set; }
        public int quantityPairs { get; set; }
        public string name { get; set; }
        public string materials { get; set; }
        public string size { get; set; }
    }
}
