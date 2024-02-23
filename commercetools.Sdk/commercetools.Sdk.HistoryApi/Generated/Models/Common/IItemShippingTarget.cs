using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ItemShippingTarget))]
    public partial interface IItemShippingTarget
    {
        string AddressKey { get; set; }

        int Quantity { get; set; }

    }
}
