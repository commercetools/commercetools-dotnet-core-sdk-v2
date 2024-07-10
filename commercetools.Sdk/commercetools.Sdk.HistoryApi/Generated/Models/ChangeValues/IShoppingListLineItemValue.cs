using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ShoppingListLineItemValue))]
    public partial interface IShoppingListLineItemValue
    {
        string Id { get; set; }

        ILocalizedString Name { get; set; }

        int VariantId { get; set; }

    }
}
