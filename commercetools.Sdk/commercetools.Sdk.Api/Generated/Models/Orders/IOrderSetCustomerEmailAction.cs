using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetCustomerEmailAction))]
    public partial interface IOrderSetCustomerEmailAction : IOrderUpdateAction
    {
        string Email { get; set;}
    }
}
