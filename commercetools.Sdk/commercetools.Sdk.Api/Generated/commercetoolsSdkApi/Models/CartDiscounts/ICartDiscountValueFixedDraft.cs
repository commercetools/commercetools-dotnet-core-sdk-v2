using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueFixedDraft))]
    public partial interface ICartDiscountValueFixedDraft : ICartDiscountValueDraft
    {
        IList<IMoney> Money { get; set; }

        IEnumerable<IMoney> MoneyEnumerable { set => Money = value.ToList(); }

        IDiscountApplicationMode ApplicationMode { get; set; }

    }
}
