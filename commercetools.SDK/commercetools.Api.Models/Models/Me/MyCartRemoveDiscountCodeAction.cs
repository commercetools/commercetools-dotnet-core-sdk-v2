using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("removeDiscountCode")]
    public partial class MyCartRemoveDiscountCodeAction : MyCartUpdateAction
    {
        public DiscountCodeReference DiscountCode { get; set;}
        public MyCartRemoveDiscountCodeAction()
        { 
           this.Action = "removeDiscountCode";
        }
    }
}
