using commercetools.Sdk.Api.Models.CartDiscounts;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeCartDiscountsAction))]
    public partial interface IDiscountCodeChangeCartDiscountsAction : IDiscountCodeUpdateAction
    {
        IList<ICartDiscountResourceIdentifier> CartDiscounts { get; set; }
        IEnumerable<ICartDiscountResourceIdentifier> CartDiscountsEnumerable { set => CartDiscounts = value.ToList(); }


    }
}
