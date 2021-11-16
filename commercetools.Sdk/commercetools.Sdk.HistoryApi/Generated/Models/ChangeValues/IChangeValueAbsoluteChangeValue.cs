using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeValueAbsoluteChangeValue))]
    public partial interface IChangeValueAbsoluteChangeValue : IChangeValueChangeValue
    {
        new string Type { get; set;}
        
        List<IMoney> Money { get; set;}
    }
}
