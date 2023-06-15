using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddDeliveryChange))]
    public partial interface IAddDeliveryChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IDeliveryChangeValue PreviousValue { get; set; }

        IDeliveryChangeValue NextValue { get; set; }

    }
}
