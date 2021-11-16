using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeQuantityChange))]
    public partial interface IChangeQuantityChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IInventoryQuantityValue NextValue { get; set; }

        IInventoryQuantityValue PreviousValue { get; set; }
    }
}
