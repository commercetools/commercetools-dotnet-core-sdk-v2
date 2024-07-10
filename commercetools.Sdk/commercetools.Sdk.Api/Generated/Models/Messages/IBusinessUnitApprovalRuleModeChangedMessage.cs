using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.BusinessUnitApprovalRuleModeChangedMessage))]
    public partial interface IBusinessUnitApprovalRuleModeChangedMessage : IMessage
    {
        IBusinessUnitApprovalRuleMode ApprovalRuleMode { get; set; }

        IBusinessUnitApprovalRuleMode OldApprovalRuleMode { get; set; }

    }
}
