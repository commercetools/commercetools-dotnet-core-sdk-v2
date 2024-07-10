using commercetools.Sdk.Api.Models.ApprovalRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApproverDisjunctionDraft : IApproverDisjunctionDraft
    {
        public IList<IRuleApproverDraft> Or { get; set; }
        public IEnumerable<IRuleApproverDraft> OrEnumerable { set => Or = value.ToList(); }

    }
}
