using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderUpdate))]
    public partial interface IOrderUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IOrderUpdate, IOrderUpdateAction>
    {
        new long Version { get; set; }
        new IList<IOrderUpdateAction> Actions { get; set; }
        IEnumerable<IOrderUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
