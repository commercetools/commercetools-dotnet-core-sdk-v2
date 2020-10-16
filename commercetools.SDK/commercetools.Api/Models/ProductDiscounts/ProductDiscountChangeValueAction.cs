using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("changeValue")]
    public partial class ProductDiscountChangeValueAction : ProductDiscountUpdateAction
    {
        public ProductDiscountValueDraft Value { get; set;}
        public ProductDiscountChangeValueAction()
        { 
           this.Action = "changeValue";
        }
    }
}
