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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountUpdate))]
    public partial interface IProductDiscountUpdate
    {
        long Version { get; set; }

        IList<IProductDiscountUpdateAction> Actions { get; set; }
        IEnumerable<IProductDiscountUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
