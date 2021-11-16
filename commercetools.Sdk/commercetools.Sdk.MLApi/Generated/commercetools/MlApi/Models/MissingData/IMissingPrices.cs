using commercetools.MLApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingPrices))]
    public partial interface IMissingPrices 
    {
        IProductReference Product { get; set;}
        
        long VariantId { get; set;}
    }
}
