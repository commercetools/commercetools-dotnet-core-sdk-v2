using commercetools.Sdk.Api.Models.ApprovalFlows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ApprovalFlows
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ApprovalFlows.ApprovalFlowSetCustomFieldAction))]
    public partial interface IApprovalFlowSetCustomFieldAction : IApprovalFlowUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
