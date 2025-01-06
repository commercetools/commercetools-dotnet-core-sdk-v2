using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountPatternTarget))]
    public partial interface ICartDiscountPatternTarget : ICartDiscountTarget
    {
        IList<IPatternComponent> TriggerPattern { get; set; }

        IEnumerable<IPatternComponent> TriggerPatternEnumerable { set => TriggerPattern = value.ToList(); }

        IList<IPatternComponent> TargetPattern { get; set; }

        IEnumerable<IPatternComponent> TargetPatternEnumerable { set => TargetPattern = value.ToList(); }

        int? MaxOccurrence { get; set; }

        ISelectionMode SelectionMode { get; set; }

    }
}
