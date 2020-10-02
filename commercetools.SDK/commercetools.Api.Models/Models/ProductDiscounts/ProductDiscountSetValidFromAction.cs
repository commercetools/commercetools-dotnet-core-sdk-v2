using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("setValidFrom")]
    public partial class ProductDiscountSetValidFromAction : ProductDiscountUpdateAction
    {
        public DateTime ValidFrom { get; set;}
        public ProductDiscountSetValidFromAction()
        { 
           this.Action = "setValidFrom";
        }
    }
}
