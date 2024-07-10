using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartAddDiscountCodeAction : IMyCartAddDiscountCodeAction
    {
        public string Action { get; set; }

        public string Code { get; set; }
        public MyCartAddDiscountCodeAction()
        {
            this.Action = "addDiscountCode";
        }
    }
}
