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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.TextLineItem))]
    public partial interface ITextLineItem
    {
        string AddedAt { get; set; }

        ICustomFields Custom { get; set; }

        ILocalizedString Description { get; set; }

        string Id { get; set; }

        ILocalizedString Name { get; set; }

        int Quantity { get; set; }

    }
}
