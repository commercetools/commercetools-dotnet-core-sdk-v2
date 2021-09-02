using commercetools.HistoryApi.Models.ChangeValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeValueExternalChangeValue))]
    public partial interface IChangeValueExternalChangeValue : IChangeValueChangeValue
    {
        new string Type { get; set; }
    }
}
