using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveParcelFromDeliveryChange))]
    public partial interface IRemoveParcelFromDeliveryChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IParcel PreviousValue { get; set; }

        string DeliveryId { get; set; }

    }
}
