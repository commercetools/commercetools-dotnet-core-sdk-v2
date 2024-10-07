using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueFixed))]
    public partial interface ICartDiscountValueFixed : ICartDiscountValue
    {
        IList<ITypedMoney> Money { get; set; }

        IEnumerable<ITypedMoney> MoneyEnumerable { set => Money = value.ToList(); }

    }
}
