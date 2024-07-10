namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeChangePlainEnumValueLabelAction : IProductTypeChangePlainEnumValueLabelAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public IAttributePlainEnumValue NewValue { get; set; }
        public ProductTypeChangePlainEnumValueLabelAction()
        {
            this.Action = "changePlainEnumValueLabel";
        }
    }
}
