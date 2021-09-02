using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.TypeRemoveFieldDefinitionAction))]
    public partial interface ITypeRemoveFieldDefinitionAction : ITypeUpdateAction
    {
        string FieldName { get; set; }
    }
}
