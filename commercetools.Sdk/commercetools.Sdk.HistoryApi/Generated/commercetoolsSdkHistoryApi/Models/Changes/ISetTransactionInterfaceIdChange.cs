using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetTransactionInterfaceIdChange))]
    public partial interface ISetTransactionInterfaceIdChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        ITransactionChangeValue Transaction { get; set; }

        string PreviousValue { get; set; }

        string NextValue { get; set; }

    }
}
