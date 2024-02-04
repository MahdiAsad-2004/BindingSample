namespace BindingSample.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Product> Products { get; set; }




        public override string ToString()
        {
            return $"{this.Id}\t{this.Title}";
        }

    }
}
