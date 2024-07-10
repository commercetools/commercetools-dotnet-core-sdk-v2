using commercetools.Sdk.Api.Models.ApprovalRules;
using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalRules
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalRules.ApprovalRule))]
    public partial interface IApprovalRule : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        ICreatedBy CreatedBy { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        string Key { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        IApprovalRuleStatus Status { get; set; }

        string Predicate { get; set; }

        IApproverHierarchy Approvers { get; set; }

        IList<IRuleRequester> Requesters { get; set; }
        IEnumerable<IRuleRequester> RequestersEnumerable { set => Requesters = value.ToList(); }


        IBusinessUnitKeyReference BusinessUnit { get; set; }

    }
}
