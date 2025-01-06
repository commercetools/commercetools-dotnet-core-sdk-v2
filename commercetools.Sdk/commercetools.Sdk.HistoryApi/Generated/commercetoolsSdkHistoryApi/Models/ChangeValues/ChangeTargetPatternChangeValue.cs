using commercetools.Sdk.HistoryApi.Models.CartDiscounts;
using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{

    public partial class ChangeTargetPatternChangeValue : IChangeTargetPatternChangeValue
    {
        public string Type { get; set; }

        public IList<IPatternComponent> TriggerPattern { get; set; }

        public IEnumerable<IPatternComponent> TriggerPatternEnumerable { set => TriggerPattern = value.ToList(); }

        public IList<IPatternComponent> TargetPattern { get; set; }

        public IEnumerable<IPatternComponent> TargetPatternEnumerable { set => TargetPattern = value.ToList(); }

        public int? MaxOccurrence { get; set; }

        public ISelectionMode SelectionMode { get; set; }
        public ChangeTargetPatternChangeValue()
        {
            this.Type = "pattern";
        }
    }
}
