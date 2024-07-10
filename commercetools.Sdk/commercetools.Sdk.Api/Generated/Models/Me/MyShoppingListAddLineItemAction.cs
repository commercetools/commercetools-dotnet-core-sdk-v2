using commercetools.Sdk.Api.Models.Me;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyShoppingListAddLineItemAction : IMyShoppingListAddLineItemAction
    {
        public string Action { get; set; }

        public string Key { get; set; }

        public string Sku { get; set; }

        public string ProductId { get; set; }

        public long? VariantId { get; set; }

        public long? Quantity { get; set; }

        public DateTime? AddedAt { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
        public MyShoppingListAddLineItemAction()
        {
            this.Action = "addLineItem";
        }
    }
}
