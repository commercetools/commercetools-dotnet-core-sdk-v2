using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.InvalidFieldError))]
    public partial interface IInvalidFieldError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string Field { get; set; }

        Object InvalidValue { get; set; }

        IList<Object> AllowedValues { get; set; }
        IEnumerable<Object> AllowedValuesEnumerable { set => AllowedValues = value.ToList(); }


    }
}
