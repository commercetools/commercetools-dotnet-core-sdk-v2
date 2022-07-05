using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeChangeLocalizedEnumValueOrderAction : IProductTypeChangeLocalizedEnumValueOrderAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public List<IAttributeLocalizedEnumValue> Values { get; set; }
        public ProductTypeChangeLocalizedEnumValueOrderAction()
        {
            this.Action = "changeLocalizedEnumValueOrder";
        }
    }
}
