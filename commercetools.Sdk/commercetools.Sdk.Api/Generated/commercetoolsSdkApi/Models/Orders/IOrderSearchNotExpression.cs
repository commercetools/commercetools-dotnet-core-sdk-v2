using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchNotExpression))]
    public partial interface IOrderSearchNotExpression : IOrderSearchCompoundExpression
    {
        IList<IOrderSearchQuery> Not { get; set; }
        IEnumerable<IOrderSearchQuery> NotEnumerable { set => Not = value.ToList(); }


    }
}
