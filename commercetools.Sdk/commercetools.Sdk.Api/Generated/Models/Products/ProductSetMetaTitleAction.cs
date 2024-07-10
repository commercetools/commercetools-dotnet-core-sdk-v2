using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetMetaTitleAction : IProductSetMetaTitleAction
    {
        public string Action { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public bool? Staged { get; set; }
        public ProductSetMetaTitleAction()
        {
            this.Action = "setMetaTitle";
        }
    }
}
