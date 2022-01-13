using commercetools.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueFixed))]
    public partial interface ICartDiscountValueFixed : ICartDiscountValue
    {
        List<ITypedMoney> Money { get; set; }
    }
}
