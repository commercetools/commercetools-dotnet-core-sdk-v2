using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.Price))]
    public partial interface IPrice 
    {
        string Id { get; set;}
        
        IMoney Value { get; set;}
    }
}
