using System.Collections.Generic;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeChangeAttributeOrderAction : IProductTypeChangeAttributeOrderAction
    {
        public string Action { get; set; }

        public List<IAttributeDefinition> Attributes { get; set; }
        public ProductTypeChangeAttributeOrderAction()
        {
            this.Action = "changeAttributeOrder";
        }
    }
}
