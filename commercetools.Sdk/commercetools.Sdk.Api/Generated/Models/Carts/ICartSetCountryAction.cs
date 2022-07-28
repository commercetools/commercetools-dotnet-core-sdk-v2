using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetCountryAction))]
    public partial interface ICartSetCountryAction : ICartUpdateAction
    {
        string Country { get; set; }

    }
}
