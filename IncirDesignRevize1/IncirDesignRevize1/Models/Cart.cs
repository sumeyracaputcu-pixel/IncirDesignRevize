namespace IncirDesignRevize1.Models
{
    public class Cart
    {
       
            public int Id { get; set; }

            public string UserId { get; set; }
            public AppUser User { get; set; }

            public List<CartItem> Items { get; set; }
       

    }
}
