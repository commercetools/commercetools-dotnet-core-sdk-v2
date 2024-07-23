using commercetools.Sdk.Api.Models.ApprovalRules;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ApprovalRuleRequestersSetMessagePayload))]
    public partial interface IApprovalRuleRequestersSetMessagePayload : IMessagePayload
    {
        IList<IRuleRequester> Requesters { get; set; }
        IEnumerable<IRuleRequester> RequestersEnumerable { set => Requesters = value.ToList(); }


        IList<IRuleRequester> OldRequesters { get; set; }
        IEnumerable<IRuleRequester> OldRequestersEnumerable { set => OldRequesters = value.ToList(); }


    }
}
