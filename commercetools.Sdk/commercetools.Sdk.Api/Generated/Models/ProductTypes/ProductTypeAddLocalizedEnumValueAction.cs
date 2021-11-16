namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeAddLocalizedEnumValueAction : IProductTypeAddLocalizedEnumValueAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public IAttributeLocalizedEnumValue Value { get; set; }
        public ProductTypeAddLocalizedEnumValueAction()
        {
            this.Action = "addLocalizedEnumValue";
        }
    }
}
