using commercetools.Sdk.Api.Models.ApprovalRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApprovalRules
{

    public partial class ApproverHierarchy : IApproverHierarchy
    {
        public IList<IApproverConjunction> Tiers { get; set; }
        public IEnumerable<IApproverConjunction> TiersEnumerable { set => Tiers = value.ToList(); }

    }
}
