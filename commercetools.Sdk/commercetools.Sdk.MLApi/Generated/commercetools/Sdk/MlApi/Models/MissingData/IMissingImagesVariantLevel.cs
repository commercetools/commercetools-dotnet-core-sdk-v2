using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingImagesVariantLevel))]
    public partial interface IMissingImagesVariantLevel : IMissingImagesCount
    {
        new long MissingImages { get; set; }

        new long Total { get; set; }
    }
}