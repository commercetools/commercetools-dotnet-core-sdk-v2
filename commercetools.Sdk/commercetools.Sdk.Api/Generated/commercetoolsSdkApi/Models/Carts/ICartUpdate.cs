using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartUpdate))]
    public partial interface ICartUpdate
    {
        long Version { get; set; }

        IList<ICartUpdateAction> Actions { get; set; }

        IEnumerable<ICartUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
