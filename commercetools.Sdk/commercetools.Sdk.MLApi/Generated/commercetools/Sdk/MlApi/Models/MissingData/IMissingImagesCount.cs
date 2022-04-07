using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingImagesCount))]
    public partial interface IMissingImagesCount
    {
        long MissingImages { get; set; }

        long Total { get; set; }
    }
}
