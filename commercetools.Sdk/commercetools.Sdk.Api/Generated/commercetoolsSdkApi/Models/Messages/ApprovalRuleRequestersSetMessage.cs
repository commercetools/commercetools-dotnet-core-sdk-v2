using commercetools.Sdk.Api.Models.ApprovalRules;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ApprovalRuleRequestersSetMessage : IApprovalRuleRequestersSetMessage
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public long SequenceNumber { get; set; }

        public IReference Resource { get; set; }

        public long ResourceVersion { get; set; }

        public string Type { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

        public IList<IRuleRequester> Requesters { get; set; }

        public IEnumerable<IRuleRequester> RequestersEnumerable { set => Requesters = value.ToList(); }

        public IList<IRuleRequester> OldRequesters { get; set; }

        public IEnumerable<IRuleRequester> OldRequestersEnumerable { set => OldRequesters = value.ToList(); }
        public ApprovalRuleRequestersSetMessage()
        {
            this.Type = "ApprovalRuleRequestersSet";
        }
    }
}
