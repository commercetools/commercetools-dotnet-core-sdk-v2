using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeQuantityChange))]
    public partial interface IChangeQuantityChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IInventoryQuantityValue PreviousValue { get; set; }

        IInventoryQuantityValue NextValue { get; set; }

    }
}
