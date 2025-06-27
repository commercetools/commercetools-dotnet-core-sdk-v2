using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupUpdate))]
    public partial interface IDiscountGroupUpdate
    {
        long Version { get; set; }

        IList<IDiscountGroupUpdateAction> Actions { get; set; }

        IEnumerable<IDiscountGroupUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
