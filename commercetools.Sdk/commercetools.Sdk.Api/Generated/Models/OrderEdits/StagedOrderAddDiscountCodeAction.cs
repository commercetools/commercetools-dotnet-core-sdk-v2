using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderAddDiscountCodeAction : IStagedOrderAddDiscountCodeAction
    {
        public string Action { get; set;}
        
        public string Code { get; set;}
        public StagedOrderAddDiscountCodeAction()
        { 
           this.Action = "addDiscountCode";
        }
    }
}
