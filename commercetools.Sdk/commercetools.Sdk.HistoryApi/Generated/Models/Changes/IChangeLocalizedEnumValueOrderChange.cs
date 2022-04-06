using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedEnumValueOrderChange))]
    public partial interface IChangeLocalizedEnumValueOrderChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string FieldName { get; set; }

        string AttributeName { get; set; }

        List<ILocalizedEnumValue> NextValue { get; set; }

        List<ILocalizedEnumValue> PreviousValue { get; set; }
    }
}
