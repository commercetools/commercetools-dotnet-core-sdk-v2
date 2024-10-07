using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetReturnInfoAction))]
    public partial interface IOrderSetReturnInfoAction : IOrderUpdateAction
    {
        IList<IReturnInfoDraft> Items { get; set; }

        IEnumerable<IReturnInfoDraft> ItemsEnumerable { set => Items = value.ToList(); }

    }
}
