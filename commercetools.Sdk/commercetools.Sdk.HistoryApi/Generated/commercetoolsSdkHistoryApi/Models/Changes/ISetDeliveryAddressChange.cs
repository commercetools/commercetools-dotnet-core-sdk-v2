using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDeliveryAddressChange))]
    public partial interface ISetDeliveryAddressChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IAddress PreviousValue { get; set; }

        IAddress NextValue { get; set; }

        string DeliveryId { get; set; }

    }
}
