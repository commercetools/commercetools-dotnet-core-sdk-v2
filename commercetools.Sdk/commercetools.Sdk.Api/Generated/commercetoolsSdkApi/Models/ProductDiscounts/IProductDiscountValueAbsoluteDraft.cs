using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueAbsoluteDraft))]
    public partial interface IProductDiscountValueAbsoluteDraft : IProductDiscountValueDraft
    {
        IList<IMoney> Money { get; set; }

        IEnumerable<IMoney> MoneyEnumerable { set => Money = value.ToList(); }

    }
}
