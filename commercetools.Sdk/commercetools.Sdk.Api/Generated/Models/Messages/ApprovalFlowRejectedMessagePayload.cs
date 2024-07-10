using commercetools.Sdk.Api.Models.Customers;
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

    public partial class ApprovalFlowRejectedMessagePayload : IApprovalFlowRejectedMessagePayload
    {
        public string Type { get; set; }

        public ICustomerReference Associate { get; set; }

        public string RejectionReason { get; set; }

        public IOrderReference Order { get; set; }
        public ApprovalFlowRejectedMessagePayload()
        {
            this.Type = "ApprovalFlowRejected";
        }
    }
}
