using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetLocaleAction))]
    public partial interface ICartSetLocaleAction : ICartUpdateAction
    {
        string Locale { get; set; }

    }
}
