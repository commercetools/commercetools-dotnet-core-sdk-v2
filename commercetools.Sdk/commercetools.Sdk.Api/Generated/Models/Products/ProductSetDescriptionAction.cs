using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Products
{
    public partial class ProductSetDescriptionAction : IProductSetDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString Description { get; set; }

        public bool? Staged { get; set; }
        public ProductSetDescriptionAction()
        {
            this.Action = "setDescription";
        }
    }
}
