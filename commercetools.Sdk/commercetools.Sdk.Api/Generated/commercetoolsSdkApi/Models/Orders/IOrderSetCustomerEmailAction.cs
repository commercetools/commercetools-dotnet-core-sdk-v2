using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetCustomerEmailAction))]
    public partial interface IOrderSetCustomerEmailAction : IOrderUpdateAction
    {
        string Email { get; set; }

    }
}
