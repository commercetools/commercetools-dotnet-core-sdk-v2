using commercetools.Sdk.Api.Models.ApprovalFlows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ApprovalFlows
{

    public partial class ApprovalFlowPagedQueryResponse : IApprovalFlowPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IApprovalFlow> Results { get; set; }
        public IEnumerable<IApprovalFlow> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
