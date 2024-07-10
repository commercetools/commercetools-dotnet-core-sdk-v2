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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Labels.OrderLabel))]
    public partial interface IOrderLabel : ILabel
    {
        new string Type { get; set; }

        string CustomerEmail { get; set; }

        string OrderNumber { get; set; }

    }
}
