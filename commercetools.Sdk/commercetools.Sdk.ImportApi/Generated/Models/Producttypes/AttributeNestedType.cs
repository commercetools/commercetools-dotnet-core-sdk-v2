using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Producttypes
{
    public partial class AttributeNestedType : IAttributeNestedType
    {
        public string Name { get; set; }

        public IProductTypeKeyReference TypeReference { get; set; }
        public AttributeNestedType()
        {
            this.Name = "nested";
        }
    }
}
