using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetKeyAction))]
    public partial interface ICartSetKeyAction : ICartUpdateAction
    {
        string Key { get; set; }
    }
}
