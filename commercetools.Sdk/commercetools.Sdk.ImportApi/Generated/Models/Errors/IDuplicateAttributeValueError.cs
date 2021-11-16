using commercetools.ImportApi.Models.Errors;
using commercetools.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.DuplicateAttributeValueError))]
    public partial interface IDuplicateAttributeValueError : IErrorObject
    {
        IAttribute Attribute { get; set;}
    }
}
