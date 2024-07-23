using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApproverConjunctionDraft))]
    public partial interface IApproverConjunctionDraft
    {
        IList<IApproverDisjunctionDraft> And { get; set; }
        IEnumerable<IApproverDisjunctionDraft> AndEnumerable { set => And = value.ToList(); }


    }
}
