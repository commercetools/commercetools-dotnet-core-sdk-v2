using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.TransactionChangeValue))]
    public partial interface ITransactionChangeValue 
    {
        string Id { get; set;}
        
        string InteractionId { get; set;}
        
        string Timestamp { get; set;}
    }
}
