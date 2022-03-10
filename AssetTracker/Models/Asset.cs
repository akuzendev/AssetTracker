namespace AssetTracker.Models
{
    public class Asset
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int qty { get; set; }

        public Asset(){
        }
    }
}
