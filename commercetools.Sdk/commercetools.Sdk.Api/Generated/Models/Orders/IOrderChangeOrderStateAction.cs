using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderChangeOrderStateAction))]
    public partial interface IOrderChangeOrderStateAction : IOrderUpdateAction
    {
        IOrderState OrderState { get; set; }

    }
}
