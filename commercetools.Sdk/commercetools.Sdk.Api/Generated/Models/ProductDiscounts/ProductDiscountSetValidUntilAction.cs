using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("setValidUntil")]
    public partial class ProductDiscountSetValidUntilAction : ProductDiscountUpdateAction
    {
        public DateTime ValidUntil { get; set;}
        public ProductDiscountSetValidUntilAction()
        { 
           this.Action = "setValidUntil";
        }
    }
}
