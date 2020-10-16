using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("changeIsActive")]
    public partial class ProductDiscountChangeIsActiveAction : ProductDiscountUpdateAction
    {
        public bool IsActive { get; set;}
        public ProductDiscountChangeIsActiveAction()
        { 
           this.Action = "changeIsActive";
        }
    }
}
