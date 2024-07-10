using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountRemoveStoreAction : ICartDiscountRemoveStoreAction
    {
        public string Action { get; set; }

        public IStoreResourceIdentifier Store { get; set; }
        public CartDiscountRemoveStoreAction()
        {
            this.Action = "removeStore";
        }
    }
}
