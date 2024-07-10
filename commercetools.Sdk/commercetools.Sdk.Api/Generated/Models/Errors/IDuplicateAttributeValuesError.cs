using commercetools.Sdk.Api.Models.Errors;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.DuplicateAttributeValuesError))]
    public partial interface IDuplicateAttributeValuesError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IList<IAttribute> Attributes { get; set; }
        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }


    }
}
