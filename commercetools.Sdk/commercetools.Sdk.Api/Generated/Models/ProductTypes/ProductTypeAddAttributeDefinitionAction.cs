namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeAddAttributeDefinitionAction : IProductTypeAddAttributeDefinitionAction
    {
        public string Action { get; set; }

        public IAttributeDefinitionDraft Attribute { get; set; }
        public ProductTypeAddAttributeDefinitionAction()
        {
            this.Action = "addAttributeDefinition";
        }
    }
}
