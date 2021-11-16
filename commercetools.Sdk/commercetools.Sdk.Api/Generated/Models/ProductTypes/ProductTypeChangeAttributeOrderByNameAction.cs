using System.Collections.Generic;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeChangeAttributeOrderByNameAction : IProductTypeChangeAttributeOrderByNameAction
    {
        public string Action { get; set;}
        
        public List<string> AttributeNames { get; set;}
        public ProductTypeChangeAttributeOrderByNameAction()
        { 
           this.Action = "changeAttributeOrderByName";
        }
    }
}
