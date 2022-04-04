using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueAbsoluteDraft))]
    public partial interface IProductDiscountValueAbsoluteDraft : IProductDiscountValueDraft
    {
        List<IMoney> Money { get; set; }
    }
}
