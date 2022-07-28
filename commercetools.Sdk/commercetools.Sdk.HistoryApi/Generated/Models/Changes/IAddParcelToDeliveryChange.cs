using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddParcelToDeliveryChange))]
    public partial interface IAddParcelToDeliveryChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string DeliveryId { get; set; }

        IParcel NextValue { get; set; }

    }
}
