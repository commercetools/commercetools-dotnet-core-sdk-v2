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
        IList<ITypedMoneyDraft> Money { get; set; }
        IEnumerable<ITypedMoneyDraft> MoneyEnumerable { set => Money = value.ToList(); }


    }
}
