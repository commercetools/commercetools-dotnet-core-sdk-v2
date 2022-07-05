using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeChangePlainEnumValueOrderAction : IProductTypeChangePlainEnumValueOrderAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public List<IAttributePlainEnumValue> Values { get; set; }
        public ProductTypeChangePlainEnumValueOrderAction()
        {
            this.Action = "changePlainEnumValueOrder";
        }
    }
}
