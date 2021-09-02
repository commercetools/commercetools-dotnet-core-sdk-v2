using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyShoppingListChangeTextLineItemNameAction : IMyShoppingListChangeTextLineItemNameAction
    {
        public string Action { get; set; }

        public string TextLineItemId { get; set; }

        public ILocalizedString Name { get; set; }
        public MyShoppingListChangeTextLineItemNameAction()
        {
            this.Action = "changeTextLineItemName";
        }
    }
}
