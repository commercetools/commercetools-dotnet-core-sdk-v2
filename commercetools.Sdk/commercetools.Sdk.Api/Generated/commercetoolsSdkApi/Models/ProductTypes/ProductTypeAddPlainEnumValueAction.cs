

namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeAddPlainEnumValueAction : IProductTypeAddPlainEnumValueAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public IAttributePlainEnumValue Value { get; set; }
        public ProductTypeAddPlainEnumValueAction()
        {
            this.Action = "addPlainEnumValue";
        }
    }
}
