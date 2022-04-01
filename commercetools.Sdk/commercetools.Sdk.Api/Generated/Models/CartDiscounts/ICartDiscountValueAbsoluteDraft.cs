using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueAbsoluteDraft))]
    public partial interface ICartDiscountValueAbsoluteDraft : ICartDiscountValueDraft
    {
        List<IMoney> Money { get; set; }
    }
}
