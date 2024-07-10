using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringSetMetaDescriptionAction : IProductTailoringSetMetaDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public bool? Staged { get; set; }
        public ProductTailoringSetMetaDescriptionAction()
        {
            this.Action = "setMetaDescription";
        }
    }
}
