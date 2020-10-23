using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountSetKeyAction))]
    public interface IProductDiscountSetKeyAction : IProductDiscountUpdateAction
    {
        string Key { get; set;}
    }
}
