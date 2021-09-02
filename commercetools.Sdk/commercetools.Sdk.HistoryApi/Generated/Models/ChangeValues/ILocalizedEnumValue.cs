using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.LocalizedEnumValue))]
    public partial interface ILocalizedEnumValue
    {
        string Key { get; set; }

        ILocalizedString Label { get; set; }
    }
}
