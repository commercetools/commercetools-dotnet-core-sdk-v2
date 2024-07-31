using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApproverConjunction))]
    public partial interface IApproverConjunction
    {
        IList<IApproverDisjunction> And { get; set; }

        IEnumerable<IApproverDisjunction> AndEnumerable { set => And = value.ToList(); }

    }
}
