using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderUpdate))]
    public partial interface IOrderUpdate
    {
        long Version { get; set; }

        IList<IOrderUpdateAction> Actions { get; set; }
        IEnumerable<IOrderUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
