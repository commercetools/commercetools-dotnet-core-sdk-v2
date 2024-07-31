

namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeChangeLocalizedEnumValueLabelAction : IProductTypeChangeLocalizedEnumValueLabelAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public IAttributeLocalizedEnumValue NewValue { get; set; }
        public ProductTypeChangeLocalizedEnumValueLabelAction()
        {
            this.Action = "changeLocalizedEnumValueLabel";
        }
    }
}
