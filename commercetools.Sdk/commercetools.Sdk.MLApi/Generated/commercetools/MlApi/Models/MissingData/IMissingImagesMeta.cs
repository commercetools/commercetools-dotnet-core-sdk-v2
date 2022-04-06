using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingImagesMeta))]
    public partial interface IMissingImagesMeta
    {
        IMissingImagesProductLevel ProductLevel { get; set; }

        IMissingImagesVariantLevel VariantLevel { get; set; }

        long Threshold { get; set; }
    }
}
