using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueAbsolute))]
    public partial interface IProductDiscountValueAbsolute : IProductDiscountValue
    {
        IList<ICentPrecisionMoney> Money { get; set; }

        IEnumerable<ICentPrecisionMoney> MoneyEnumerable { set => Money = value.ToList(); }

    }
}
