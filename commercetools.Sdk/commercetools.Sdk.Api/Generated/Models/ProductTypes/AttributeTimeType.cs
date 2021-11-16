namespace commercetools.Api.Models.ProductTypes
{
    public partial class AttributeTimeType : IAttributeTimeType
    {
        public string Name { get; set; }
        public AttributeTimeType()
        {
            this.Name = "time";
        }
    }
}
