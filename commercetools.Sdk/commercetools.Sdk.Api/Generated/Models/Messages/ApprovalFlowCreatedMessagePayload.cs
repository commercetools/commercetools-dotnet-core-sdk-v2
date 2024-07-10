using commercetools.Sdk.Api.Models.ApprovalFlows;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ApprovalFlowCreatedMessagePayload : IApprovalFlowCreatedMessagePayload
    {
        public string Type { get; set; }

        public IApprovalFlow ApprovalFlow { get; set; }
        public ApprovalFlowCreatedMessagePayload()
        {
            this.Type = "ApprovalFlowCreated";
        }
    }
}
