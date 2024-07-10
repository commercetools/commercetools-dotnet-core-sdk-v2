using commercetools.Sdk.ImportApi.Models.Errors;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Errors.DuplicateAttributeValuesError))]
    public partial interface IDuplicateAttributeValuesError : IErrorObject
    {
        IList<IAttribute> Attributes { get; set; }
        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }


    }
}
