using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ShippingMethodChangeIsDefaultChange))]
    public partial interface IShippingMethodChangeIsDefaultChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        bool PreviousValue { get; set; }

        bool NextValue { get; set; }

    }
}
