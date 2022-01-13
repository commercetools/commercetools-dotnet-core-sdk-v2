using commercetools.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountValueAbsolute))]
    public partial interface IProductDiscountValueAbsolute : IProductDiscountValue
    {
        List<ITypedMoney> Money { get; set; }
    }
}
