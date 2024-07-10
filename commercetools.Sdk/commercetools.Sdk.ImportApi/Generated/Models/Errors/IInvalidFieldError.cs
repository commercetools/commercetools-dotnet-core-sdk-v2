using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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
