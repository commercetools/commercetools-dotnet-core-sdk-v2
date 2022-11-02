using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingAttributesDetails))]
    public partial interface IMissingAttributesDetails
    {
        int Total { get; set; }

        int MissingAttributeNames { get; set; }

        int MissingAttributeValues { get; set; }

    }
}
