using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLInvalidFieldError : IGraphQLInvalidFieldError
    {
        public string Code { get; set; }

        public string Field { get; set; }

        public Object InvalidValue { get; set; }

        public IList<Object> AllowedValues { get; set; }
        public IEnumerable<Object> AllowedValuesEnumerable { set => AllowedValues = value.ToList(); }

        public GraphQLInvalidFieldError()
        {
            this.Code = "InvalidField";
        }
    }
}
