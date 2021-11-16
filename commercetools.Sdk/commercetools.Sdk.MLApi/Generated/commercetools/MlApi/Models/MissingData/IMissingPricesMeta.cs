using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingPricesMeta))]
    public partial interface IMissingPricesMeta 
    {
        IMissingPricesProductLevel ProductLevel { get; set;}
        
        IMissingPricesVariantLevel VariantLevel { get; set;}
    }
}
