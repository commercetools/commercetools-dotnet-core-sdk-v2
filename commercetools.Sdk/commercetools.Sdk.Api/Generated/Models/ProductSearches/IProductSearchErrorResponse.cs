using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
