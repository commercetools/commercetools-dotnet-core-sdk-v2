using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetDirectDiscountsAction))]
    public partial interface ICartSetDirectDiscountsAction : ICartUpdateAction
    {
        List<IDirectDiscountDraft> Discounts { get; set; }

    }
}
