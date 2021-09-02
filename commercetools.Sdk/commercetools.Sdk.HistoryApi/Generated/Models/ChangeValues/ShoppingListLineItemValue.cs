using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class ShoppingListLineItemValue : IShoppingListLineItemValue
    {
        public string Id { get; set; }

        public ILocalizedString Name { get; set; }

        public int VariantId { get; set; }
    }
}
