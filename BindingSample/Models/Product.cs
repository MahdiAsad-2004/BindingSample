namespace BindingSample.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }
        public Dictionary<string,string> Tags { get; set; }






        public override string ToString()
        {
            return $"{this.Id}\t{this.Name}";
        }

    }
}
