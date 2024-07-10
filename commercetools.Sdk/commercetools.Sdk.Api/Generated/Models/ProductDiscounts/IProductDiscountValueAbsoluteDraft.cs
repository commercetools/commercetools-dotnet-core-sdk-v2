using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
