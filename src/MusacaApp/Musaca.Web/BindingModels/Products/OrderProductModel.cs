using SIS.MvcFramework.Attributes.Validation;

namespace Musaca.App.BindingModels.Products
{
    public class OrderProductModel
    {
        [RequiredSis]
        public string Product { get; set; }
    }
}
