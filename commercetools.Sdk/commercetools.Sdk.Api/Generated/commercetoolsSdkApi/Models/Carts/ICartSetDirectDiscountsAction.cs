using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetDirectDiscountsAction))]
    public partial interface ICartSetDirectDiscountsAction : ICartUpdateAction
    {
        IList<IDirectDiscountDraft> Discounts { get; set; }

        IEnumerable<IDirectDiscountDraft> DiscountsEnumerable { set => Discounts = value.ToList(); }

    }
}
