using commercetools.Sdk.Api.Models.Common;
using System;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLDuplicateFieldWithConflictingResourceError : IGraphQLDuplicateFieldWithConflictingResourceError
    {
        public string Code { get; set; }

        public string Field { get; set; }

        public Object DuplicateValue { get; set; }

        public IReference ConflictingResource { get; set; }
        public GraphQLDuplicateFieldWithConflictingResourceError()
        {
            this.Code = "DuplicateFieldWithConflictingResource";
        }
    }
}
