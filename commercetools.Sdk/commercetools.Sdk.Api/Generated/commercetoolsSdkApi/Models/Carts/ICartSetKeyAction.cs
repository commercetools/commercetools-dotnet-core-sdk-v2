using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetKeyAction))]
    public partial interface ICartSetKeyAction : ICartUpdateAction
    {
        string Key { get; set; }

    }
}
