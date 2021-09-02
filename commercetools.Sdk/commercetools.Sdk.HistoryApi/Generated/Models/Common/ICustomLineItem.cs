using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.CustomLineItem))]
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
