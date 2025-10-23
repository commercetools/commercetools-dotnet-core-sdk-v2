using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetItemShippingAddressCustomTypeChange))]
    public partial interface ISetItemShippingAddressCustomTypeChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        string AddressId { get; set; }

        ICustomFields PreviousValue { get; set; }

        ICustomFields NextValue { get; set; }

    }
}
