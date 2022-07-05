namespace commercetools.Sdk.MLApi.Models.MissingData
{

    public partial class MissingAttributesDetails : IMissingAttributesDetails
    {
        public int Total { get; set; }

        public int MissingAttributeNames { get; set; }

        public int MissingAttributeValues { get; set; }
    }
}
