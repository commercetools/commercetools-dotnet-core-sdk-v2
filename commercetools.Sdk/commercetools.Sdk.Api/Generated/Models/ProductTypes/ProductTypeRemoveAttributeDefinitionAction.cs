namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeRemoveAttributeDefinitionAction : IProductTypeRemoveAttributeDefinitionAction
    {
        public string Action { get; set;}
        
        public string Name { get; set;}
        public ProductTypeRemoveAttributeDefinitionAction()
        { 
           this.Action = "removeAttributeDefinition";
        }
    }
}
