namespace Models
{
    public class Knife
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }

        public Knife(string brand, string type)
        {
            this.Brand = brand;
            this.Type = type;
        }
    }
}