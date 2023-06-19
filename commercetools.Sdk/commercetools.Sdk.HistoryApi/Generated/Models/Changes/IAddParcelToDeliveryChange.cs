using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddParcelToDeliveryChange))]
    public partial interface IAddParcelToDeliveryChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IParcel NextValue { get; set; }

        string DeliveryId { get; set; }

    }
}
