using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeShipmentStateChange))]
    public partial interface IChangeShipmentStateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IShipmentState NextValue { get; set; }

        IShipmentState PreviousValue { get; set; }

    }
}
