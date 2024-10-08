using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueAbsolute))]
    public partial interface ICartDiscountValueAbsolute : ICartDiscountValue
    {
        IList<ICentPrecisionMoney> Money { get; set; }

        IEnumerable<ICentPrecisionMoney> MoneyEnumerable { set => Money = value.ToList(); }

        IDiscountApplicationMode ApplicationMode { get; set; }

    }
}
