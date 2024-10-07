using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangePlainEnumValueOrderChange))]
    public partial interface IChangePlainEnumValueOrderChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IEnumValue> PreviousValue { get; set; }

        IEnumerable<IEnumValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<IEnumValue> NextValue { get; set; }

        IEnumerable<IEnumValue> NextValueEnumerable { set => NextValue = value.ToList(); }

        string AttributeName { get; set; }

    }
}
