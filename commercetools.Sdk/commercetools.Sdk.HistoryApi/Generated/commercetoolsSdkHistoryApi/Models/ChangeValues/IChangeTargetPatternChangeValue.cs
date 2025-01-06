using commercetools.Sdk.HistoryApi.Models.CartDiscounts;
using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.ChangeTargetPatternChangeValue))]
    public partial interface IChangeTargetPatternChangeValue : IChangeTargetChangeValue
    {
        new string Type { get; set; }

        IList<IPatternComponent> TriggerPattern { get; set; }

        IEnumerable<IPatternComponent> TriggerPatternEnumerable { set => TriggerPattern = value.ToList(); }

        IList<IPatternComponent> TargetPattern { get; set; }

        IEnumerable<IPatternComponent> TargetPatternEnumerable { set => TargetPattern = value.ToList(); }

        int? MaxOccurrence { get; set; }

        ISelectionMode SelectionMode { get; set; }

    }
}
