using commercetools.HistoryApi.Models.ChangeValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeValueRelativeChangeValue))]
    public partial interface IChangeValueRelativeChangeValue : IChangeValueChangeValue
    {
        new string Type { get; set; }

        int Permyriad { get; set; }
    }
}
