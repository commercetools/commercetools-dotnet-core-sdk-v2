using commercetools.Sdk.Api.Models.Errors;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductSearches
{

    public partial class ProductSearchErrorResponse : IProductSearchErrorResponse
    {
        public int StatusCode { get; set; }

        public string Message { get; set; }

        public IList<IErrorObject> Errors { get; set; }

        public IEnumerable<IErrorObject> ErrorsEnumerable { set => Errors = value.ToList(); }
    }
}
