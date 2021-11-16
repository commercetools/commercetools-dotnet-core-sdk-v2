using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetCustomerEmailAction))]
    public partial interface ICartSetCustomerEmailAction : ICartUpdateAction
    {
        string Email { get; set; }
    }
}
