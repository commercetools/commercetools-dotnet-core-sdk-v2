using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLUnauthorizedError : IGraphQLUnauthorizedError
    {
        public string Code { get; set; }

        public IList<string> StoresWithoutPermission { get; set; }

        public IEnumerable<string> StoresWithoutPermissionEnumerable { set => StoresWithoutPermission = value.ToList(); }
        public GraphQLUnauthorizedError()
        {
            this.Code = "Unauthorized";
        }
    }
}
