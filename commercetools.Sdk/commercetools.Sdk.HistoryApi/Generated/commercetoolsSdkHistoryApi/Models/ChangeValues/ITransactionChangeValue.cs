using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.TransactionChangeValue))]
    public partial interface ITransactionChangeValue
    {
        string Id { get; set; }

        string InteractionId { get; set; }

        string Timestamp { get; set; }

    }
}
