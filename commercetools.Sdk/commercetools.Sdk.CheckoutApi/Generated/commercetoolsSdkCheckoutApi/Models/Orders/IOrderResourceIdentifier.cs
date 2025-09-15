using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Orders.OrderResourceIdentifier))]
    public partial interface IOrderResourceIdentifier : IResourceIdentifier
    {
        new string Id { get; set; }

        new string Key { get; set; }

    }
}
