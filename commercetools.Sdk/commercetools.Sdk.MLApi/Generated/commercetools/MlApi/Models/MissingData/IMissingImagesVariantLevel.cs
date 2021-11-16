using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingImagesVariantLevel))]
    public partial interface IMissingImagesVariantLevel : IMissingImagesCount
    {
        new long MissingImages { get; set;}
        
        new long Total { get; set;}
    }
}
