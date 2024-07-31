using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodUpdate))]
    public partial interface IShippingMethodUpdate
    {
        long Version { get; set; }

        IList<IShippingMethodUpdateAction> Actions { get; set; }

        IEnumerable<IShippingMethodUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
