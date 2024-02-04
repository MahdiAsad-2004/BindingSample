namespace BindingSample.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }







        public override string ToString()
        {
            return $"{this.Id}\t{this.Title}\t{this.Value}";
        }
    }
}
