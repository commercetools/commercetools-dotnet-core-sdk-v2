using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountChangeNameAction))]
    public partial interface IProductDiscountChangeNameAction : IProductDiscountUpdateAction
    {
        ILocalizedString Name { get; set;}
    }
}
