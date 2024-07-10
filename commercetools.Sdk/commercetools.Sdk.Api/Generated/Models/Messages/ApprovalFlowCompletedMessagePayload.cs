using commercetools.Sdk.Api.Models.ApprovalFlows;
using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ApprovalFlowCompletedMessagePayload : IApprovalFlowCompletedMessagePayload
    {
        public string Type { get; set; }

        public IApprovalFlowStatus Status { get; set; }

        public IOrderReference Order { get; set; }
        public ApprovalFlowCompletedMessagePayload()
        {
            this.Type = "ApprovalFlowCompleted";
        }
    }
}
