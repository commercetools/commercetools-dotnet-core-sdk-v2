using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListRemoveLineItemAction : IMyShoppingListRemoveLineItemAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public long? Quantity { get; set; }
        public MyShoppingListRemoveLineItemAction()
        {
            this.Action = "removeLineItem";
        }
    }
}
