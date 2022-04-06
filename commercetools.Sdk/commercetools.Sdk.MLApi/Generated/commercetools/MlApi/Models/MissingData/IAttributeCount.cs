using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.AttributeCount))]
    public partial interface IAttributeCount
    {
        int ProductTypeAttributes { get; set; }

        int VariantAttributes { get; set; }

        int MissingAttributeValues { get; set; }
    }
}
