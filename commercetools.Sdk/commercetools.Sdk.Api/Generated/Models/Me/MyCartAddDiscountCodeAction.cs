using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public  partial class MyCartAddDiscountCodeAction : IMyCartAddDiscountCodeAction
    {
        public string Action { get; set;}
        
        public string Code { get; set;}
        public MyCartAddDiscountCodeAction()
        { 
           this.Action = "addDiscountCode";
        }
    }
}
