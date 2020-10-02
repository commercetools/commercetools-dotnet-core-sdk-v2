using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("addDiscountCode")]
    public partial class MyCartAddDiscountCodeAction : MyCartUpdateAction
    {
        public string Code { get; set;}
        public MyCartAddDiscountCodeAction()
        { 
           this.Action = "addDiscountCode";
        }
    }
}
