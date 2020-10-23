using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Types
{
    public interface ITypeChangeFieldDefinitionOrderAction : ITypeUpdateAction
    {
        List<string> FieldNames { get; set;}
    }
}
