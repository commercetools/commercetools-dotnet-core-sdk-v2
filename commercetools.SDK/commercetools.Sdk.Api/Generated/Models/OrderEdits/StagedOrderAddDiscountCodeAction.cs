using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("addDiscountCode")]
    public partial class StagedOrderAddDiscountCodeAction : StagedOrderUpdateAction
    {
        public string Code { get; set;}
        public StagedOrderAddDiscountCodeAction()
        { 
           this.Action = "addDiscountCode";
        }
    }
}
