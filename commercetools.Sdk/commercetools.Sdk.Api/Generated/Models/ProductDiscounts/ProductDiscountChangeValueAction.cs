using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountChangeValueAction : IProductDiscountChangeValueAction
    {
        public string Action { get; set;}
        
        public IProductDiscountValueDraft Value { get; set;}
        public ProductDiscountChangeValueAction()
        { 
           this.Action = "changeValue";
        }
    }
}
