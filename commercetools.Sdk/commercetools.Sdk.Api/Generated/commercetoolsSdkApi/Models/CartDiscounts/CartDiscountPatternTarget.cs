using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountPatternTarget : ICartDiscountPatternTarget
    {
        public string Type { get; set; }

        public IList<IPatternComponent> TriggerPattern { get; set; }

        public IEnumerable<IPatternComponent> TriggerPatternEnumerable { set => TriggerPattern = value.ToList(); }

        public IList<IPatternComponent> TargetPattern { get; set; }

        public IEnumerable<IPatternComponent> TargetPatternEnumerable { set => TargetPattern = value.ToList(); }

        public int? MaxOccurrence { get; set; }

        public ISelectionMode SelectionMode { get; set; }
        public CartDiscountPatternTarget()
        {
            this.Type = "pattern";
        }
    }
}
