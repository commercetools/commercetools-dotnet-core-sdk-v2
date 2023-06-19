using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditDraft))]
    public partial interface IOrderEditDraft
    {
        string Key { get; set; }

        IOrderReference Resource { get; set; }

        IList<IStagedOrderUpdateAction> StagedActions { get; set; }
        IEnumerable<IStagedOrderUpdateAction> StagedActionsEnumerable { set => StagedActions = value.ToList(); }


        ICustomFieldsDraft Custom { get; set; }

        string Comment { get; set; }

        bool? DryRun { get; set; }

    }
}
