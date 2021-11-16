using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetCustomerIdAction))]
    public partial interface ICartSetCustomerIdAction : ICartUpdateAction
    {
        string CustomerId { get; set;}
    }
}
