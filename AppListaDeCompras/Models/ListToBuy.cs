namespace AppListaDeCompras.Models
{
    public class ListToBuy
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Product> Products { get; set; } = new List<Product>();
        public List<User> Users { get; set; }
        public DateTimeOffset CreateAt { get; set; }
    }
}
