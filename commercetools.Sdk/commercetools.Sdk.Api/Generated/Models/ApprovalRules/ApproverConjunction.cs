using commercetools.Sdk.Api.Models.ApprovalRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApproverConjunction : IApproverConjunction
    {
        public IList<IApproverDisjunction> And { get; set; }
        public IEnumerable<IApproverDisjunction> AndEnumerable { set => And = value.ToList(); }

    }
}
