using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveItemShippingAddressesChange))]
    public partial interface IRemoveItemShippingAddressesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IAddress PreviousValue { get; set; }

        IAddress NextValue { get; set; }

    }
}
