using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderReference))]
    public partial interface IOrderReference : IReference
    {
        IOrder Obj { get; set; }
    }
}
