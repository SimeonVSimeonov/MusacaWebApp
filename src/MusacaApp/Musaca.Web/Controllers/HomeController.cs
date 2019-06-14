using Musaca.App.ViewModels.Orders;
using Musaca.Models;
using Musaca.Services;
using SIS.MvcFramework;
using SIS.MvcFramework.Attributes;
using SIS.MvcFramework.Result;
using SIS.MvcFramework.Mapping;
using Musaca.App.ViewModels.Products;

namespace Musaca.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderService orderService;

        public HomeController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet(Url = "/")]
        public IActionResult IndexSlash()
        {
            return this.Index();
        }

        public IActionResult Index()
        {
            OrderHomeViewModel orderHomeViewModel = new OrderHomeViewModel();

            if (this.IsLoggedIn())
            {
                Order order = this.orderService
                    .GetCurrentActiveOrderByCashierId(this.User.Id);
                if (order == null)
                {
                    return this.View(orderHomeViewModel);
                }
                orderHomeViewModel = order.ProjectTo<OrderHomeViewModel>();
               
                orderHomeViewModel.Products.Clear();

                foreach (var orderProduct in order.Products)
                {
                    ProductHomeViewModel productHomeViewModel = orderProduct.Product.ProjectTo<ProductHomeViewModel>();

                    orderHomeViewModel.Products.Add(productHomeViewModel);
                }
            }

            return this.View(orderHomeViewModel);
        }
    }
}
