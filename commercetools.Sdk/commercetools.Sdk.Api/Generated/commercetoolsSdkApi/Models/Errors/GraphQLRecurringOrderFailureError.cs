using System;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLRecurringOrderFailureError : IGraphQLRecurringOrderFailureError
    {
        public string Code { get; set; }

        public Object Details { get; set; }
        public GraphQLRecurringOrderFailureError()
        {
            this.Code = "RecurringOrderFailure";
        }
    }
}
