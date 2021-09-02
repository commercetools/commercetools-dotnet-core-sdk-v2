using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderRemoveDiscountCodeAction : IStagedOrderRemoveDiscountCodeAction
    {
        public string Action { get; set; }

        public IDiscountCodeReference DiscountCode { get; set; }
        public StagedOrderRemoveDiscountCodeAction()
        {
            this.Action = "removeDiscountCode";
        }
    }
}
