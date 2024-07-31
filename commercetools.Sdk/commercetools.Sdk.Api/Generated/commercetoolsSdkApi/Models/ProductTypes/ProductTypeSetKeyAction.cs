

namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeSetKeyAction : IProductTypeSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public ProductTypeSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
