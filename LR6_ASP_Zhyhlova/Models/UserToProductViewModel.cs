namespace LR6_ASP_Zhyhlova.Models
{
    public class UserToProductViewModel
    {
        public int NumberOfProducts { get; set; }

        public string Email { get; set; }

        public uint Age { get; set; }

        public Product[] Products { get; set; }

        public UserToProductViewModel() { }

        public UserToProductViewModel(int numberOfProducts, string email, uint age)
        {
            Email = email;
            Age = age;
            NumberOfProducts = numberOfProducts;
            Products = new Product[numberOfProducts];

            for (var i = 0; i < numberOfProducts; i++)
            {

                Products[i] = new Product(i + 1);
            }
        }
    }
}
