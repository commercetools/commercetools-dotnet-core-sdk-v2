using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangePaymentStateChange))]
    public partial interface IChangePaymentStateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IPaymentState NextValue { get; set; }

        IPaymentState PreviousValue { get; set; }
    }
}
