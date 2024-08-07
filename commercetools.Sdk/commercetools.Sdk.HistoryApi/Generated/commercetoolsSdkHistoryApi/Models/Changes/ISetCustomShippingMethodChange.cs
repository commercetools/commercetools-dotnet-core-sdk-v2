using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomShippingMethodChange))]
    public partial interface ISetCustomShippingMethodChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ICustomShippingMethodChangeValue PreviousValue { get; set; }

        ICustomShippingMethodChangeValue NextValue { get; set; }

    }
}
