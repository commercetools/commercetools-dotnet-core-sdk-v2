using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("removeDiscountCode")]
    public partial class StagedOrderRemoveDiscountCodeAction : StagedOrderUpdateAction
    {
        public DiscountCodeReference DiscountCode { get; set;}
        public StagedOrderRemoveDiscountCodeAction()
        { 
           this.Action = "removeDiscountCode";
        }
    }
}
