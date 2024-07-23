using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetReturnInfoAction))]
    public partial interface IStagedOrderSetReturnInfoAction : IStagedOrderUpdateAction
    {
        IList<IReturnInfoDraft> Items { get; set; }
        IEnumerable<IReturnInfoDraft> ItemsEnumerable { set => Items = value.ToList(); }


    }
}
