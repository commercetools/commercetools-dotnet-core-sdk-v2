using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.ItemShippingTarget))]
    public partial interface IItemShippingTarget
    {
        string AddressKey { get; set; }

        long Quantity { get; set; }

    }
}
