using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomerEmailAction))]
    public partial interface ICartSetCustomerEmailAction : ICartUpdateAction
    {
        string Email { get; set; }
    }
}
