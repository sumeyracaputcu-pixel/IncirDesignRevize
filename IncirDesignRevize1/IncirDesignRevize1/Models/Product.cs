using System.ComponentModel.DataAnnotations.Schema;

namespace IncirDesignRevize1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int Stock { get; set; }
        public bool IsActive { get; set; } = true;
        public string ImageUrl { get; set; }
        public string Description { get; set; }



    }
}
