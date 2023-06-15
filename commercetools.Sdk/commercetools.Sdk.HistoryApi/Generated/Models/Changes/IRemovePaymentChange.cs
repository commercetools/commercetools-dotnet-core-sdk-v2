using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemovePaymentChange))]
    public partial interface IRemovePaymentChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IPaymentInfo PreviousValue { get; set; }

        IPaymentInfo NextValue { get; set; }

    }
}
