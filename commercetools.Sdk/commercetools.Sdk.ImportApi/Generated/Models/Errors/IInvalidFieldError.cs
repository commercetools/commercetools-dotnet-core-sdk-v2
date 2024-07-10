using commercetools.Sdk.ImportApi.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.InvalidFieldError))]
    public partial interface IInvalidFieldError : IErrorObject
    {
        string Field { get; set; }

        Object InvalidValue { get; set; }

        IList<Object> AllowedValues { get; set; }
        IEnumerable<Object> AllowedValuesEnumerable { set => AllowedValues = value.ToList(); }


        long? ResourceIndex { get; set; }

    }
}
