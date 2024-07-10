using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListLineItemDraft : IShoppingListLineItemDraft
    {
        public string Key { get; set; }

        public string ProductId { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public DateTime? AddedAt { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public long? Quantity { get; set; }
    }
}
