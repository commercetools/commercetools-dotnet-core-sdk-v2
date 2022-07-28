using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingMethodChange))]
    public partial interface ISetShippingMethodChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IShippingMethodChangeValue NextValue { get; set; }

        IShippingMethodChangeValue PreviousValue { get; set; }

    }
}
