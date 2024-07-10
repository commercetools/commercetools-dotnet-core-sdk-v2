using commercetools.Sdk.Api.Models.ApprovalRules;
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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRuleRequestersSetMessage))]
    public partial interface IApprovalRuleRequestersSetMessage : IMessage
    {
        IList<IRuleRequester> Requesters { get; set; }
        IEnumerable<IRuleRequester> RequestersEnumerable { set => Requesters = value.ToList(); }


        IList<IRuleRequester> OldRequesters { get; set; }
        IEnumerable<IRuleRequester> OldRequestersEnumerable { set => OldRequesters = value.ToList(); }


    }
}
