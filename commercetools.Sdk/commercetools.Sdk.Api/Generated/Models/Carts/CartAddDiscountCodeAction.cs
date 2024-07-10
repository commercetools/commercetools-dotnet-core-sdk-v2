using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartAddDiscountCodeAction : ICartAddDiscountCodeAction
    {
        public string Action { get; set; }

        public string Code { get; set; }
        public CartAddDiscountCodeAction()
        {
            this.Action = "addDiscountCode";
        }
    }
}
