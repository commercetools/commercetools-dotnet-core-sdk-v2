namespace commercetools.ImportApi.Models.Producttypes
{
    public partial class AttributeNumberType : IAttributeNumberType
    {
        public string Name { get; set; }
        public AttributeNumberType()
        {
            this.Name = "number";
        }
    }
}
