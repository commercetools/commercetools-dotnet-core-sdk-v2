using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListChangeTextLineItemsOrderAction : IMyShoppingListChangeTextLineItemsOrderAction
    {
        public string Action { get; set; }

        public IList<string> TextLineItemOrder { get; set; }
        public IEnumerable<string> TextLineItemOrderEnumerable { set => TextLineItemOrder = value.ToList(); }

        public MyShoppingListChangeTextLineItemsOrderAction()
        {
            this.Action = "changeTextLineItemsOrder";
        }
    }
}
