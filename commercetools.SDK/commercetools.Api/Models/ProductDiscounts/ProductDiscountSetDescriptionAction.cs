using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("setDescription")]
    public partial class ProductDiscountSetDescriptionAction : ProductDiscountUpdateAction
    {
        public LocalizedString Description { get; set;}
        public ProductDiscountSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
