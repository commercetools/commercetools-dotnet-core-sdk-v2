using commercetools.HistoryApi.Models.Common;
using commercetools.HistoryApi.Models.Labels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Labels.LocalizedLabel))]
    public partial interface ILocalizedLabel : ILabel
    {
        new string Type { get; set;}
        
        ILocalizedString Value { get; set;}
    }
}
