using Microsoft.AspNetCore.Mvc.Rendering;

namespace SencondMvc.Models
{
    public class ProductViewModel
    {
        public string Product { get; set; }

        public List<SelectListItem> Products { get; set; } = new List<SelectListItem>();
    }
}
