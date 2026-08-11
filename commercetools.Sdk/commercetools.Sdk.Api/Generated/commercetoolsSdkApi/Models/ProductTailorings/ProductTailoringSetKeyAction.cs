

namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringSetKeyAction : IProductTailoringSetKeyAction
    {
        public string Action { get; set; }

        public string Key { get; set; }
        public ProductTailoringSetKeyAction()
        {
            this.Action = "setKey";
        }
    }
}
