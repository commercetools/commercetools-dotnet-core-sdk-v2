namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeChangeAttributeNameAction : IProductTypeChangeAttributeNameAction
    {
        public string Action { get; set;}
        
        public string AttributeName { get; set;}
        
        public string NewAttributeName { get; set;}
        public ProductTypeChangeAttributeNameAction()
        { 
           this.Action = "changeAttributeName";
        }
    }
}
