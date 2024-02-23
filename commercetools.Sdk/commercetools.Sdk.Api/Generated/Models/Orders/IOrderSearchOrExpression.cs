using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchOrExpression))]
    public partial interface IOrderSearchOrExpression : IOrderSearchCompoundExpression
    {
        IList<IOrderSearchQuery> Or { get; set; }
        IEnumerable<IOrderSearchQuery> OrEnumerable { set => Or = value.ToList(); }


    }
}
