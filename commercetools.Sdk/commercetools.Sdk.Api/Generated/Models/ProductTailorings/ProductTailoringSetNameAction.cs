using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringSetNameAction : IProductTailoringSetNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }

        public bool? Staged { get; set; }
        public ProductTailoringSetNameAction()
        {
            this.Action = "setName";
        }
    }
}
