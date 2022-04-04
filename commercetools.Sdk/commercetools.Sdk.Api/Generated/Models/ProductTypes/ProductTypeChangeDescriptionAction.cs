namespace commercetools.Sdk.Api.Models.ProductTypes
{
    public partial class ProductTypeChangeDescriptionAction : IProductTypeChangeDescriptionAction
    {
        public string Action { get; set; }

        public string Description { get; set; }
        public ProductTypeChangeDescriptionAction()
        {
            this.Action = "changeDescription";
        }
    }
}
