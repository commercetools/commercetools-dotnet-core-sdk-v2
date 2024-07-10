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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueAbsolute))]
    public partial interface IProductDiscountValueAbsolute : IProductDiscountValue
    {
        IList<ICentPrecisionMoney> Money { get; set; }
        IEnumerable<ICentPrecisionMoney> MoneyEnumerable { set => Money = value.ToList(); }


    }
}
