using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.RemoveItemShippingAddressesChange))]
    public partial interface IRemoveItemShippingAddressesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IAddress NextValue { get; set; }

        IAddress PreviousValue { get; set; }
    }
}
