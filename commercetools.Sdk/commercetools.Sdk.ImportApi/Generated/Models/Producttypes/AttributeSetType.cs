namespace commercetools.Sdk.ImportApi.Models.Producttypes
{

    public partial class AttributeSetType : IAttributeSetType
    {
        public string Name { get; set; }

        public IAttributeType ElementType { get; set; }
        public AttributeSetType()
        {
            this.Name = "set";
        }
    }
}
