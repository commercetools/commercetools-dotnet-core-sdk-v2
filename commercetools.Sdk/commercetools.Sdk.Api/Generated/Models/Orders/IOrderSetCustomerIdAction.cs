using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetCustomerIdAction))]
    public partial interface IOrderSetCustomerIdAction : IOrderUpdateAction
    {
        string CustomerId { get; set;}
    }
}
