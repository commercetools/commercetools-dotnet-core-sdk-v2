using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeCartDiscountsAction))]
    public partial interface IDiscountCodeChangeCartDiscountsAction : IDiscountCodeUpdateAction
    {
        IList<ICartDiscountResourceIdentifier> CartDiscounts { get; set; }
        IEnumerable<ICartDiscountResourceIdentifier> CartDiscountsEnumerable { set => CartDiscounts = value.ToList(); }


    }
}
