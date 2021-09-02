using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeChangeCartDiscountsAction))]
    public partial interface IDiscountCodeChangeCartDiscountsAction : IDiscountCodeUpdateAction
    {
        List<ICartDiscountResourceIdentifier> CartDiscounts { get; set; }
    }
}
