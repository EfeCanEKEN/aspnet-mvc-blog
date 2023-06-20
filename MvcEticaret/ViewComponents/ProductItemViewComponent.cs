using Microsoft.AspNetCore.Mvc;

namespace MvcEticaret.ViewComponents
{
    public class ProductItemViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string title, int startCount, decimal oldPrice, decimal price, string imageUrl, bool isSale)
        {
            ViewData["Title"] = title;
            ViewData["StartCount"] = startCount;
            ViewData["OldPrice"] = oldPrice;
            ViewData["Price"] = price;
            ViewData["ImageUrl"] = imageUrl;
            ViewData["IsSale"] = isSale;

            return View();
        }
    }
}
