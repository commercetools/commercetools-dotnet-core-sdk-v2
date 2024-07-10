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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApproverConjunctionDraft))]
    public partial interface IApproverConjunctionDraft
    {
        IList<IApproverDisjunctionDraft> And { get; set; }
        IEnumerable<IApproverDisjunctionDraft> AndEnumerable { set => And = value.ToList(); }


    }
}
