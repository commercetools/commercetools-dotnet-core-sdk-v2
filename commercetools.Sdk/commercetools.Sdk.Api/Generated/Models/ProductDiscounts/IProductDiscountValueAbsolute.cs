using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueAbsolute))]
    public partial interface IProductDiscountValueAbsolute : IProductDiscountValue
    {
        List<ICentPrecisionMoney> Money { get; set; }

    }
}
