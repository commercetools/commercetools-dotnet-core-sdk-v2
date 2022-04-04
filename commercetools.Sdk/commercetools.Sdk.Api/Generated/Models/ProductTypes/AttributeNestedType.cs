namespace commercetools.Sdk.Api.Models.ProductTypes
{
    public partial class AttributeNestedType : IAttributeNestedType
    {
        public string Name { get; set; }

        public IProductTypeReference TypeReference { get; set; }
        public AttributeNestedType()
        {
            this.Name = "nested";
        }
    }
}
