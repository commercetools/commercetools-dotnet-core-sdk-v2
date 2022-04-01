using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetBillingAddressAction))]
    public partial interface IOrderSetBillingAddressAction : IOrderUpdateAction
    {
        IBaseAddress Address { get; set; }
    }
}
