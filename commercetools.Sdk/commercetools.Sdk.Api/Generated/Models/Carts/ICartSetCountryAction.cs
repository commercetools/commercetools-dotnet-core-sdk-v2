using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetCountryAction))]
    public partial interface ICartSetCountryAction : ICartUpdateAction
    {
        string Country { get; set; }
    }
}
