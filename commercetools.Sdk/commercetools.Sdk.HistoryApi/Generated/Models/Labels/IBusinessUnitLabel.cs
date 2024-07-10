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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Labels.BusinessUnitLabel))]
    public partial interface IBusinessUnitLabel : ILabel
    {
        new string Type { get; set; }

        string Key { get; set; }

        string Name { get; set; }

    }
}
