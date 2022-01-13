using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetBillingAddressChange))]
    public partial interface ISetBillingAddressChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IAddress NextValue { get; set; }

        IAddress PreviousValue { get; set; }
    }
}
