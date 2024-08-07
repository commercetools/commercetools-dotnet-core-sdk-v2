using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomerIdAction))]
    public partial interface ICartSetCustomerIdAction : ICartUpdateAction
    {
        string CustomerId { get; set; }

    }
}
