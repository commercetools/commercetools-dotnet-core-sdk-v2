using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApproverHierarchy))]
    public partial interface IApproverHierarchy
    {
        IList<IApproverConjunction> Tiers { get; set; }

        IEnumerable<IApproverConjunction> TiersEnumerable { set => Tiers = value.ToList(); }

    }
}
