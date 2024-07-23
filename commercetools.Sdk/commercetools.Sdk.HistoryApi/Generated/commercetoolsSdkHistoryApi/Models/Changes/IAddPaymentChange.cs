using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddPaymentChange))]
    public partial interface IAddPaymentChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IPaymentInfo PreviousValue { get; set; }

        IPaymentInfo NextValue { get; set; }

    }
}
