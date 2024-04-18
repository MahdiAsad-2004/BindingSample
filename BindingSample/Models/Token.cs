namespace BindingSample.Models
{
    public class Token
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Email { get; set; }







        public override string ToString()
        {
            return $"{this.Id}\t{this.Key}\t{this.Email}";
        }
    }
}
