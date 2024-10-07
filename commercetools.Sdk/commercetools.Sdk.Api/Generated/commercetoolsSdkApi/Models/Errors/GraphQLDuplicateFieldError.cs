using System;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLDuplicateFieldError : IGraphQLDuplicateFieldError
    {
        public string Code { get; set; }

        public string Field { get; set; }

        public Object DuplicateValue { get; set; }
        public GraphQLDuplicateFieldError()
        {
            this.Code = "DuplicateField";
        }
    }
}
