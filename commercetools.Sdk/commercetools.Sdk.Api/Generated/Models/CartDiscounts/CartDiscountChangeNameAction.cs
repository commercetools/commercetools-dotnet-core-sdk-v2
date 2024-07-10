using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountChangeNameAction : ICartDiscountChangeNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public CartDiscountChangeNameAction()
        {
            this.Action = "changeName";
        }
    }
}
