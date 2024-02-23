using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchFilterExpression))]
    public partial interface IOrderSearchFilterExpression : IOrderSearchCompoundExpression
    {
        IList<IOrderSearchQueryExpression> Filter { get; set; }
        IEnumerable<IOrderSearchQueryExpression> FilterEnumerable { set => Filter = value.ToList(); }


    }
}
