using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueAbsoluteDraft))]
    public partial interface ICartDiscountValueAbsoluteDraft : ICartDiscountValueDraft
    {
        IList<IMoney> Money { get; set; }
        IEnumerable<IMoney> MoneyEnumerable { set => Money = value.ToList(); }


    }
}
