using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListLineItemDraft : IShoppingListLineItemDraft
    {
        public DateTime? AddedAt { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public string Sku { get; set; }

        public string ProductId { get; set; }

        public int? Quantity { get; set; }

        public long? VariantId { get; set; }
    }
}
