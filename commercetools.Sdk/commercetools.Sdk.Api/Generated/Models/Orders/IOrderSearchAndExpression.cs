using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchAndExpression))]
    public partial interface IOrderSearchAndExpression : IOrderSearchCompoundExpression
    {
        IList<IOrderSearchQuery> And { get; set; }
        IEnumerable<IOrderSearchQuery> AndEnumerable { set => And = value.ToList(); }


    }
}
