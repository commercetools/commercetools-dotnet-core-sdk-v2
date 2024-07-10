using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueFixedDraft))]
    public partial interface ICartDiscountValueFixedDraft : ICartDiscountValueDraft
    {
        IList<IMoney> Money { get; set; }
        IEnumerable<IMoney> MoneyEnumerable { set => Money = value.ToList(); }


    }
}
