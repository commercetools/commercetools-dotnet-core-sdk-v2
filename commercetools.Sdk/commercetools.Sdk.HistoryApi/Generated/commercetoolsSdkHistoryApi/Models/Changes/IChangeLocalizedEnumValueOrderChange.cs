using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeLocalizedEnumValueOrderChange))]
    public partial interface IChangeLocalizedEnumValueOrderChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IAttributeLocalizedEnumValue> PreviousValue { get; set; }

        IEnumerable<IAttributeLocalizedEnumValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<IAttributeLocalizedEnumValue> NextValue { get; set; }

        IEnumerable<IAttributeLocalizedEnumValue> NextValueEnumerable { set => NextValue = value.ToList(); }

        string FieldName { get; set; }

        string AttributeName { get; set; }

    }
}
