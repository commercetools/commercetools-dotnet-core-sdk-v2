using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.RemoveDeliveryItemsChange))]
    public partial interface IRemoveDeliveryItemsChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IDelivery PreviousValue { get; set; }
    }
}
