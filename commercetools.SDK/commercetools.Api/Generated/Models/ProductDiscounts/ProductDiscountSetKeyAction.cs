using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("setKey")]
    public partial class ProductDiscountSetKeyAction : ProductDiscountUpdateAction
    {
        public string Key { get; set;}
        public ProductDiscountSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
