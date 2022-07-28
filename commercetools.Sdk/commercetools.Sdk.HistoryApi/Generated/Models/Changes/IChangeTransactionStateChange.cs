using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTransactionStateChange))]
    public partial interface IChangeTransactionStateChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        ITransactionChangeValue Transaction { get; set; }

        ITransactionState NextValue { get; set; }

        ITransactionState PreviousValue { get; set; }

    }
}
