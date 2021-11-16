using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingImagesProductLevel))]
    public partial interface IMissingImagesProductLevel : IMissingImagesCount
    {
        new long MissingImages { get; set;}
        
        new long Total { get; set;}
    }
}
