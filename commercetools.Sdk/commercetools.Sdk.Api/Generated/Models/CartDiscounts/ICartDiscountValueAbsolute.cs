using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueAbsolute))]
    public partial interface ICartDiscountValueAbsolute : ICartDiscountValue
    {
        List<ICentPrecisionMoney> Money { get; set; }

    }
}
