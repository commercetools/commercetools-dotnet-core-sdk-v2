using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingPricesPagedQueryResult))]
    public partial interface IMissingPricesPagedQueryResult 
    {
        long Count { get; set;}
        
        long Total { get; set;}
        
        long Offset { get; set;}
        
        List<IMissingPrices> Results { get; set;}
        
        IMissingPricesMeta Meta { get; set;}
    }
}
