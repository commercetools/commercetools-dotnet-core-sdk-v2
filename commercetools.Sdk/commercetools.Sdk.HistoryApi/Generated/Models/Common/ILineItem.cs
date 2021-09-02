using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.LineItem))]
    public partial interface ILineItem
    {
        string AddedAt { get; set; }

        ICustomFields Custom { get; set; }

        string Id { get; set; }

        ILocalizedString Name { get; set; }

        string ProductId { get; set; }

        ILocalizedString ProductSlug { get; set; }

        IReference ProductType { get; set; }

        int Quantity { get; set; }

        IVariant Variant { get; set; }

        int VariantId { get; set; }
    }
}
