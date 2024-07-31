using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetOrderTotalTaxAction))]
    public partial interface IStagedOrderSetOrderTotalTaxAction : IStagedOrderUpdateAction
    {
        IMoney ExternalTotalGross { get; set; }

        IList<ITaxPortionDraft> ExternalTaxPortions { get; set; }

        IEnumerable<ITaxPortionDraft> ExternalTaxPortionsEnumerable { set => ExternalTaxPortions = value.ToList(); }

    }
}
