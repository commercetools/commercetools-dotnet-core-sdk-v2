using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeEnumValueOrderChange))]
    public partial interface IChangeEnumValueOrderChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<ICustomFieldEnumValue> PreviousValue { get; set; }

        IEnumerable<ICustomFieldEnumValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<ICustomFieldEnumValue> NextValue { get; set; }

        IEnumerable<ICustomFieldEnumValue> NextValueEnumerable { set => NextValue = value.ToList(); }

        string FieldName { get; set; }

        string AttributeName { get; set; }

    }
}
