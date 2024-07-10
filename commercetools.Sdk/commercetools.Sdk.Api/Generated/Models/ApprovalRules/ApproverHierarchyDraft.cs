using commercetools.Sdk.Api.Models.ApprovalRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApproverHierarchyDraft : IApproverHierarchyDraft
    {
        public IList<IApproverConjunctionDraft> Tiers { get; set; }
        public IEnumerable<IApproverConjunctionDraft> TiersEnumerable { set => Tiers = value.ToList(); }

    }
}
