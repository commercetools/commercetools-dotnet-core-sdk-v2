using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetAnonymousIdAction))]
    public partial interface ICartSetAnonymousIdAction : ICartUpdateAction
    {
        string AnonymousId { get; set;}
    }
}
