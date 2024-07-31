using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderChangeOrderStateAction))]
    public partial interface IOrderChangeOrderStateAction : IOrderUpdateAction
    {
        IOrderState OrderState { get; set; }

    }
}
