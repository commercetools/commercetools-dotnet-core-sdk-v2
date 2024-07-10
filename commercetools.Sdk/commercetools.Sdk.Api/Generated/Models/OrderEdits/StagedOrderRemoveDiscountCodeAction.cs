using commercetools.Sdk.Api.Models.DiscountCodes;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
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
