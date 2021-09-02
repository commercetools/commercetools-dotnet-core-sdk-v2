using commercetools.HistoryApi.Models.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Labels.StringLabel))]
    public partial interface IStringLabel : ILabel
    {
        new string Type { get; set; }

        string Value { get; set; }
    }
}
