using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDeliveryAddressChange))]
    public partial interface ISetDeliveryAddressChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string DeliveryId { get; set; }

        IAddress NextValue { get; set; }

        IAddress PreviousValue { get; set; }

    }
}
