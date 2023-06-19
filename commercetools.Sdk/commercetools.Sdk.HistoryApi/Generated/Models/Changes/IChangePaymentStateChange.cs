using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangePaymentStateChange))]
    public partial interface IChangePaymentStateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IPaymentState PreviousValue { get; set; }

        IPaymentState NextValue { get; set; }

    }
}
