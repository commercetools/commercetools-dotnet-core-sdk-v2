using commercetools.Sdk.HistoryApi.Models.Common;
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

        IList<IAttributePlainEnumValue> PreviousValue { get; set; }

        IEnumerable<IAttributePlainEnumValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<IAttributePlainEnumValue> NextValue { get; set; }

        IEnumerable<IAttributePlainEnumValue> NextValueEnumerable { set => NextValue = value.ToList(); }

        string AttributeName { get; set; }

    }
}
