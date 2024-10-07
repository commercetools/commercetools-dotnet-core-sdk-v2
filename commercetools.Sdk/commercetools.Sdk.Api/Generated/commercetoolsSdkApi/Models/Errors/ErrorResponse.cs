using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ErrorResponse : IErrorResponse
    {
        public int StatusCode { get; set; }

        public string Message { get; set; }

        public IList<IErrorObject> Errors { get; set; }

        public IEnumerable<IErrorObject> ErrorsEnumerable { set => Errors = value.ToList(); }
    }
}
