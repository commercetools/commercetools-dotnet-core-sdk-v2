using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetBillingAddressAction))]
    public partial interface IStagedOrderSetBillingAddressAction : IStagedOrderUpdateAction
    {
        IBaseAddress Address { get; set; }

    }
}
