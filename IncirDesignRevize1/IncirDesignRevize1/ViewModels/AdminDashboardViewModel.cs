using IncirDesignRevize1.Models;

namespace IncirDesignRevize1.ViewModels
{
    public class AdminDashboardViewModel
    {
        public List<OrderViewModel> Orders { get; set; }

        public List<ProductDetailViewModel> Products { get; set; }
    }
}
