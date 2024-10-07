using commercetools.Sdk.Api.Models.Errors;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchErrorResponse))]
    public partial interface IProductSearchErrorResponse : IErrorResponse
    {
        new int StatusCode { get; set; }

        new string Message { get; set; }

        new IList<IErrorObject> Errors { get; set; }

        new IEnumerable<IErrorObject> ErrorsEnumerable { set => Errors = value.ToList(); }

    }
}
