using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{

    public partial class ShoppingListLineItemValue : IShoppingListLineItemValue
    {
        public string Id { get; set; }

        public ILocalizedString Name { get; set; }

        public int VariantId { get; set; }
    }
}
