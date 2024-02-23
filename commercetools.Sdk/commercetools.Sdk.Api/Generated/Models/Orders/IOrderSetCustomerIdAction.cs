using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetCustomerIdAction))]
    public partial interface IOrderSetCustomerIdAction : IOrderUpdateAction
    {
        string CustomerId { get; set; }

    }
}
