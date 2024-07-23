using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringSetSlugAction : IProductTailoringSetSlugAction
    {
        public string Action { get; set; }

        public ILocalizedString Slug { get; set; }

        public bool? Staged { get; set; }
        public ProductTailoringSetSlugAction()
        {
            this.Action = "setSlug";
        }
    }
}
