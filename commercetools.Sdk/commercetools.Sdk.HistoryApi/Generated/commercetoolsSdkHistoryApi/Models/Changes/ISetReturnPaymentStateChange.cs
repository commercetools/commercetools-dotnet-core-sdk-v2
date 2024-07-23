using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetReturnPaymentStateChange))]
    public partial interface ISetReturnPaymentStateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IReturnPaymentState PreviousValue { get; set; }

        IReturnPaymentState NextValue { get; set; }

    }
}
