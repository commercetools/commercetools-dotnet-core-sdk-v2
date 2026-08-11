using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class UnauthorizedError : IUnauthorizedError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IList<string> StoresWithoutPermission { get; set; }

        public IEnumerable<string> StoresWithoutPermissionEnumerable { set => StoresWithoutPermission = value.ToList(); }
        public UnauthorizedError()
        {
            this.Code = "Unauthorized";
        }
    }
}
