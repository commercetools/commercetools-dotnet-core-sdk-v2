using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;
using System.Linq;
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

        IList<ILocalizedEnumValue> NextValue { get; set; }
        IEnumerable<ILocalizedEnumValue> NextValueEnumerable { set => NextValue = value.ToList(); }


        IList<ILocalizedEnumValue> PreviousValue { get; set; }
        IEnumerable<ILocalizedEnumValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


    }
}
