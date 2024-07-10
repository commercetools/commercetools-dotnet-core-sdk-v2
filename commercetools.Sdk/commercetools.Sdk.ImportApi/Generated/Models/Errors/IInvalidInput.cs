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
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.InvalidInput))]
    public partial interface IInvalidInput : IErrorObject
    {


    }
}
