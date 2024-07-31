using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderUpdateItemShippingAddressAction))]
    public partial interface IStagedOrderUpdateItemShippingAddressAction : IStagedOrderUpdateAction
    {
        IBaseAddress Address { get; set; }

    }
}
