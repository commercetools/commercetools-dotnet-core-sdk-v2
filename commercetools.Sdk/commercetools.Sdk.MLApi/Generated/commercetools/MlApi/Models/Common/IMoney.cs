using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.Common.Money))]
    public partial interface IMoney 
    {
        long CentAmount { get; set;}
        
        string CurrencyCode { get; set;}
    }
}
