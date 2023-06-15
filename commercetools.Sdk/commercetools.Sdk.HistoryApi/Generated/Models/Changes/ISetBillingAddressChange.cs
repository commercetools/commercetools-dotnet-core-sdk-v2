using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetBillingAddressChange))]
    public partial interface ISetBillingAddressChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IAddress PreviousValue { get; set; }

        IAddress NextValue { get; set; }

    }
}
