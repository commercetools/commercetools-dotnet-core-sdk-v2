using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderChangeOrderStateAction))]
    public partial interface IOrderChangeOrderStateAction : IOrderUpdateAction
    {
        IOrderState OrderState { get; set;}
    }
}
