using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeFieldDefinitionOrderChange))]
    public partial interface IChangeFieldDefinitionOrderChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IFieldDefinitionOrderValue> PreviousValue { get; set; }

        IEnumerable<IFieldDefinitionOrderValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<IFieldDefinitionOrderValue> NextValue { get; set; }

        IEnumerable<IFieldDefinitionOrderValue> NextValueEnumerable { set => NextValue = value.ToList(); }

    }
}
