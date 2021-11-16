using commercetools.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountValueAbsoluteDraft))]
    public partial interface IProductDiscountValueAbsoluteDraft : IProductDiscountValueDraft
    {
        List<IMoney> Money { get; set; }
    }
}
