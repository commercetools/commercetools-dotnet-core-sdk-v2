using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.DiscountedLineItemPrice))]
    public partial interface IDiscountedLineItemPrice
    {
        ITypedMoney Value { get; set; }

        List<IDiscountedLineItemPortion> IncludedDiscounts { get; set; }
    }
}
