using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingCustomTypeChange))]
    public partial interface ISetShippingCustomTypeChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        string ShippingKey { get; set; }

        ICustomFields PreviousValue { get; set; }

        ICustomFields NextValue { get; set; }

    }
}
