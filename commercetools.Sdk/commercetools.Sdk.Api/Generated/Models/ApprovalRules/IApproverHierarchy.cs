using commercetools.Sdk.Api.Models.ApprovalRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
