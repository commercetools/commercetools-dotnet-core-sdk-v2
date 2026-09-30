using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetDirectDiscountsIgnoreCartDiscountsAction))]
    public partial interface ICartSetDirectDiscountsIgnoreCartDiscountsAction : ICartUpdateAction
    {
        bool? DirectDiscountsIgnoreCartDiscounts { get; set; }

    }
}
