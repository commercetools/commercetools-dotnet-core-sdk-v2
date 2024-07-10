using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApproverDisjunction))]
    public partial interface IApproverDisjunction
    {
        IList<IRuleApprover> Or { get; set; }
        IEnumerable<IRuleApprover> OrEnumerable { set => Or = value.ToList(); }


    }
}
