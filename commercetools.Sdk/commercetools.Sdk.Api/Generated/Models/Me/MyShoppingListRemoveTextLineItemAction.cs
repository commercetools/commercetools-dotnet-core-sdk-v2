using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListRemoveTextLineItemAction : IMyShoppingListRemoveTextLineItemAction
    {
        public string Action { get; set; }

        public string TextLineItemId { get; set; }

        public string TextLineItemKey { get; set; }

        public long? Quantity { get; set; }
        public MyShoppingListRemoveTextLineItemAction()
        {
            this.Action = "removeTextLineItem";
        }
    }
}
