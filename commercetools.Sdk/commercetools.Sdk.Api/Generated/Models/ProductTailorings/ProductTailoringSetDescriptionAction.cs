using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringSetDescriptionAction : IProductTailoringSetDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }

        public bool? Staged { get; set; }
        public ProductTailoringSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
