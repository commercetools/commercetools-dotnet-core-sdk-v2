namespace commercetools.Sdk.MLApi.Models.MissingData
{
    public partial class AttributeCount : IAttributeCount
    {
        public int ProductTypeAttributes { get; set; }

        public int VariantAttributes { get; set; }

        public int MissingAttributeValues { get; set; }
    }
}
