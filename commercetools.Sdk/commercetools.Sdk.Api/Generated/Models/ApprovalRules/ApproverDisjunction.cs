using commercetools.Sdk.Api.Models.ApprovalRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApproverDisjunction : IApproverDisjunction
    {
        public IList<IRuleApprover> Or { get; set; }
        public IEnumerable<IRuleApprover> OrEnumerable { set => Or = value.ToList(); }

    }
}
