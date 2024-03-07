namespace LR6_ASP_Zhyhlova.Models
{
    public class Product
    {
        public int Id { get; }

        public string Title { get; set; }

        public Product(int id)
        {
            Id = id;
        }

        public Product() { }
    }
}
