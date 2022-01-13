using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.AttributeCount))]
    public partial interface IAttributeCount
    {
        int ProductTypeAttributes { get; set; }

        int VariantAttributes { get; set; }

        int MissingAttributeValues { get; set; }
    }
}
