using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetAnonymousIdAction))]
    public partial interface ICartSetAnonymousIdAction : ICartUpdateAction
    {
        string AnonymousId { get; set; }

    }
}
