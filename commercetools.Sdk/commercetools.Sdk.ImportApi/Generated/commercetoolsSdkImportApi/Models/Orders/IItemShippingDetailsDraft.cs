using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.ItemShippingDetailsDraft))]
    public partial interface IItemShippingDetailsDraft
    {
        IList<IItemShippingTarget> Targets { get; set; }

        IEnumerable<IItemShippingTarget> TargetsEnumerable { set => Targets = value.ToList(); }

    }
}
