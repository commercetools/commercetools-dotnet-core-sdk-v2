namespace commercetools.Sdk.Api.Models.ProductTypes
{
    public partial class AttributeDateTimeType : IAttributeDateTimeType
    {
        public string Name { get; set; }
        public AttributeDateTimeType()
        {
            this.Name = "datetime";
        }
    }
}
