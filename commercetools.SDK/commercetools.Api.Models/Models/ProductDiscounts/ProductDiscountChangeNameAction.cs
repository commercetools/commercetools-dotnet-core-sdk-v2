using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("changeName")]
    public partial class ProductDiscountChangeNameAction : ProductDiscountUpdateAction
    {
        public LocalizedString Name { get; set;}
        public ProductDiscountChangeNameAction()
        { 
           this.Action = "changeName";
        }
    }
}
