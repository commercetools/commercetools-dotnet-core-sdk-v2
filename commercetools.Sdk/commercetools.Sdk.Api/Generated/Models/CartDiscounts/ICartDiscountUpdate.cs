using commercetools.Sdk.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountUpdate))]
    public partial interface ICartDiscountUpdate
    {
        long Version { get; set; }

        IList<ICartDiscountUpdateAction> Actions { get; set; }
        IEnumerable<ICartDiscountUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
