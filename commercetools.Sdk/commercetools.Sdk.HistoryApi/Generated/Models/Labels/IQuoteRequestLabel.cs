using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Sdk.HistoryApi.Models.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Labels.QuoteRequestLabel))]
    public partial interface IQuoteRequestLabel : ILabel
    {
        new string Type { get; set; }

        string Key { get; set; }

        IReference Customer { get; set; }

    }
}
