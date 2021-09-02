using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartRemoveDiscountCodeAction : IMyCartRemoveDiscountCodeAction
    {
        public string Action { get; set; }

        public IDiscountCodeReference DiscountCode { get; set; }
        public MyCartRemoveDiscountCodeAction()
        {
            this.Action = "removeDiscountCode";
        }
    }
}
