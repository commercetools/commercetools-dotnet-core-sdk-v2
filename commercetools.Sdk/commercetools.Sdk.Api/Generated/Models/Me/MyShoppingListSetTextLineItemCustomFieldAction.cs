using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListSetTextLineItemCustomFieldAction : IMyShoppingListSetTextLineItemCustomFieldAction
    {
        public string Action { get; set; }

        public string TextLineItemId { get; set; }

        public string TextLineItemKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public MyShoppingListSetTextLineItemCustomFieldAction()
        {
            this.Action = "setTextLineItemCustomField";
        }
    }
}
