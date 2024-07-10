using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.CustomLineItem))]
    public partial interface ICustomLineItem
    {
        string Id { get; set; }

        ILocalizedString Name { get; set; }

        IMoney Money { get; set; }

        ITaxedItemPrice TaxedPrice { get; set; }

        IMoney TotalPrice { get; set; }

        string Slug { get; set; }

        int Quantity { get; set; }

    }
}
