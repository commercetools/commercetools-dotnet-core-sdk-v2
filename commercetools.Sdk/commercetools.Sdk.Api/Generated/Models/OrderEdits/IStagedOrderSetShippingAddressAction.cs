using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetShippingAddressAction))]
    public partial interface IStagedOrderSetShippingAddressAction : IStagedOrderUpdateAction
    {
        IBaseAddress Address { get; set; }

    }
}
