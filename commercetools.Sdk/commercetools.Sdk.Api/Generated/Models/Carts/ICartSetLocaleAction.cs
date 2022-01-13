using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetLocaleAction))]
    public partial interface ICartSetLocaleAction : ICartUpdateAction
    {
        string Locale { get; set; }
    }
}
