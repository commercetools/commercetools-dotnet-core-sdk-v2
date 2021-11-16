using System.Collections.Generic;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeRemoveEnumValuesAction : IProductTypeRemoveEnumValuesAction
    {
        public string Action { get; set; }

        public string AttributeName { get; set; }

        public List<string> Keys { get; set; }
        public ProductTypeRemoveEnumValuesAction()
        {
            this.Action = "removeEnumValues";
        }
    }
}
